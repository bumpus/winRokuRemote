using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Win32;
using System.Xml;
using System.Threading;

namespace WinRokuRemote
{
    public partial class RemoteForm : Form
    {
        /*Declare a bunch of string constants to define the buttons and command strings*/
        const String BUTTON_HOME="Home";
        const String BUTTON_REW="Rev";
        const String BUTTON_FWD="Fwd";
        const String BUTTON_PLAY="Play";
        const String BUTTON_SELECT="Select";
        const String BUTTON_LEFT="Left";
        const String BUTTON_RIGHT="Right";
        const String BUTTON_DOWN="Down";
        const String BUTTON_UP="Up";
        const String BUTTON_BACK="Back";
        const String BUTTON_INSTANTREPLAY="InstantReplay";
        const String BUTTON_INFO = "Info";

        const String KEY_NAME = "Software\\Bump.us\\RokuRemote";
        const String VALUE_NAME_ROKU_IP = "RokuIP";
        RegistryKey key;

        bool searching;
        System.Timers.Timer searchTimer;
        const int searchTime = 3;

        Thread getRokuDevicesThread, getChannelsThread;

        public RemoteForm()
        {
            InitializeComponent();
            RemoveCursorNavigation(this.tabControl1.Controls);
            cbRoku.Items.Clear();
            
            searchTimer = new System.Timers.Timer(1000 * searchTime);
            searchTimer.Elapsed += new ElapsedEventHandler(searchTimeout);

            key = Registry.CurrentUser.CreateSubKey(KEY_NAME);

            getRokuDevicesThread = new Thread(new ThreadStart(getRokuDevices));
            getRokuDevicesThread.Start();
        }

        private void RemoveCursorNavigation(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.PreviewKeyDown += new PreviewKeyDownEventHandler(MainWin_PreviewKeyDown);
                RemoveCursorNavigation(ctrl.Controls);
            }
        }

        public void MainWin_PreviewKeyDown(Object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
                default:
                    break;
            }
        }

        private void onRemoteButtonPress(object sender, MouseEventArgs e)
        {
            String command = "keydown/" + DetermineButton(sender);
            label1.Text = command;
            SendHTTPCommand(command);
        }

        private void onRemoteButtonRelease(object sender, MouseEventArgs e)
        {
            String command = "keyup/" + DetermineButton(sender);
            label1.Text = command;
            SendHTTPCommand(command);
        }

        private String DetermineButton(object sender)
        {
            String retval;
            if (sender.ToString() == btn_back.ToString())
                retval = BUTTON_BACK;
            else if (sender.ToString() == btn_down.ToString())
                retval = BUTTON_DOWN;
            else if (sender.ToString() == btn_fwd.ToString())
                retval=BUTTON_FWD;
            else if (sender.ToString() == btn_home.ToString())
                retval=BUTTON_HOME;
            else if (sender.ToString() == btn_info.ToString())
                retval=BUTTON_INFO;
            else if (sender.ToString() == btn_instantReplay.ToString())
                retval=BUTTON_INSTANTREPLAY;
            else if (sender.ToString() == btn_left.ToString())
                retval=BUTTON_LEFT;
            else if (sender.ToString() == btn_play.ToString())
                retval=BUTTON_PLAY;
            else if (sender.ToString() == btn_rev.ToString())
                retval=BUTTON_REW;
            else if (sender.ToString() == btn_right.ToString())
                retval=BUTTON_RIGHT;
            else if (sender.ToString() == btn_select.ToString())
                retval=BUTTON_SELECT;
            else if (sender.ToString() == btn_up.ToString())
                retval=BUTTON_UP;
            else
                retval="ERROR";

            return retval;

        }

        private void SendHTTPCommand(String command)
        {
            // This method posts a command to the roku. It does not check for a response. Commands almost
            // always succeed unless there is a network error.
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://" + cbRoku.Text + ":8060/" + command);
                HttpWebResponse resp;
                req.Method = "POST";
                resp = (HttpWebResponse)req.GetResponse();
            }catch
            {
                MessageBox.Show("Couldn't contact Roku");
            }
        }

        private String SendHTTPQuery(String query)
        {
            String returnValue = "";
            try
            {
                
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://" + cbRoku.Text + ":8060/" + query);
                HttpWebResponse resp;

                req.Method = "GET";

                resp = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = resp.GetResponseStream();
                StreamReader readStream = new StreamReader(ReceiveStream, System.Text.Encoding.GetEncoding("utf-8"));
                Char[] read = new Char[256];

                // Read 256 charcters at a time.    
                int count = readStream.Read(read, 0, 256);

                while (count > 0)
                {
                    // Dump the 256 characters on a string and display the string onto the console.
                    returnValue += new String(read, 0, count);
                    count = readStream.Read(read, 0, 256);
                }
            }
            catch
            {
                MessageBox.Show("Couldn't contact Roku");
                return "";
            }
            return returnValue;
            
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            String key = "";
            String command = "";
            if (DetermineKey(e, ref key))
            {
                command = "keydown/" + key;
                label1.Text = command;
               SendHTTPCommand(command);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = "Release " + e.KeyCode;
            String key = "";
            String command = "";
            if (DetermineKey(e, ref key))
            {
                command = "keyup/" + key;
                label1.Text = command;
                SendHTTPCommand(command);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private bool DetermineKey(KeyEventArgs e, ref String key)
        {
            //Returns true or false to determine if the key is something we're going to handle
            //The Key parameter will be populated with the String corresponding with the key name in
            //the Roku's post command if it's one we're going to use.

            //Note that there are buttons on the remote that don't have a keyboard shortcut defined here.
            bool found = true;
            key ="";
            switch(e.KeyCode){
                case Keys.Back:
                    key = BUTTON_BACK;
                    break;
                case Keys.Left:
                    key = BUTTON_LEFT;
                    break;
                case Keys.Right:
                    key = BUTTON_RIGHT;
                    break;
                case Keys.Up:
                    key = BUTTON_UP;
                    break;
                case Keys.Down:
                    key = BUTTON_DOWN;
                    break;
                case Keys.Home:
                    key = BUTTON_HOME;
                    break;
                case Keys.Space:
                    key = BUTTON_SELECT;
                    break;
                default:
                    found = false;
                    break;
            };
            return found;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the channel list if we have selected the channel tab
            if(1 == tabControl1.SelectedIndex)
            {
                String xmlList = SendHTTPQuery("query/apps");
                using (XmlReader reader = XmlReader.Create(new StringReader(xmlList)))
                {
                    while (reader.ReadToFollowing("app"))
                    {
                        int id = Convert.ToInt32(reader.GetAttribute("id"));
                        string appname = reader.ReadElementContentAsString();
                        lbChannelList.Items.Add(appname);
                    }
                }

            }
        }

        private void getRokuDevices()
        {
            List<string> rokuList = new List<string>();
            int selectedRoku = -1;

            IPEndPoint LocalEndPoint = new IPEndPoint(IPAddress.Any, 0);
            IPEndPoint MulticastEndPoint = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);

            Socket UdpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            UdpSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            UdpSocket.Bind(LocalEndPoint);
            UdpSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(MulticastEndPoint.Address, IPAddress.Any));
            UdpSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
            UdpSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback, true);

            string SearchString = "M-SEARCH * HTTP/1.1\r\nHost: 239.255.255.250:1900\r\nMan: \"ssdp:discover\"\r\nST: roku:ecp\r\n\r\n";

            UdpSocket.SendTo(Encoding.UTF8.GetBytes(SearchString), SocketFlags.None, MulticastEndPoint);

            byte[] ReceiveBuffer = new byte[64000];

            int ReceivedBytes = 0;

            searching = true;
            searchTimer.Enabled = true;

            while (searching)
            {
                if (UdpSocket.Available > 0)
                {
                    ReceivedBytes = UdpSocket.Receive(ReceiveBuffer, SocketFlags.None);

                    if (ReceivedBytes > 0)
                    {
                        string receivedText = Encoding.ASCII.GetString(ReceiveBuffer);
                        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("LOCATION: http://(.*):8060/");
                        var match = regex.Match(receivedText);
                        if (match.Success)
                        {
                            rokuList.Add(match.Groups[1].Value);
                        }
                    }
                }
            }

            //See if we found the Roku we were using last time. If so use it, else use the first one we found.
            if (rokuList.Count != 0)
            {
                object temp = key.GetValue(VALUE_NAME_ROKU_IP);
                if (null != temp)
                {
                    selectedRoku = rokuList.IndexOf(Convert.ToString(temp));
                    if (-1 == selectedRoku)
                    { 
                        selectedRoku = 0;
                    }
                }
                else
                {
                    cbRoku.SelectedIndex = 0;
                }
            }

            updateRokuComboBox(rokuList, selectedRoku);
        }

        private void updateRokuComboBox(List<string> rokuList, int selectedRoku)
        {
            // Cross thread - so you don't get the cross-threading exception
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    updateRokuComboBox(rokuList, selectedRoku);
                });
                return;
            }

            cbRoku.Items.Clear();
            foreach(string i in rokuList)
            {
                cbRoku.Items.Add(i);
            }
            cbRoku.SelectedIndex = selectedRoku;
        }

        private void searchTimeout(object sender, EventArgs e)
        {
            searching = false;
        }

        private void cbRoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            key.SetValue(VALUE_NAME_ROKU_IP, cbRoku.SelectedItem.ToString(), RegistryValueKind.String);
        }
    }
}

