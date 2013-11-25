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


namespace WindowsFormsApplication1
{
    public partial class RemoteForm : Form
    {
        /*Declare a bunch of string constants to define the buttons and command strings*/
        const String BUTTON_HOME="Home";
        const String BUTTON_REW="Rew";
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

        public RemoteForm()
        {
            InitializeComponent();
        }

        private void RemoteForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            //switch (e.KeyCode)
            //{
            //    default:
                    
            //}
        }

        private void RemoteForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void onRemoteButtonPress(object sender, MouseEventArgs e)
        {
            String command = "POST /keydown/" + DetermineButton(sender);// +" HTTP/1.0\r\n";
            label1.Text = command;
        }

        private void onRemoteButtonRelease(object sender, MouseEventArgs e)
        {
            String command = "POST /keyup/" + DetermineButton(sender);// + " HTTP/1.0\r\n";
            label1.Text = command;
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
            else if (sender.ToString() == btn_rew.ToString())
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
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://192.168.0.16:8060/"+command);
            HttpWebResponse resp;
            req.Method= "POST";
            req.ContentLength = 3;

            
            byte[] content;
            content = new byte[5];
            content[0] = 48;
            content[1] = 49;
            content[2] = 50;
            content[3] = 0;

            using (Stream stream = req.GetRequestStream())
            {
                stream.Write(content, 0, content.Length);
            }

            resp = (HttpWebResponse)req.GetResponse();

            //IPAddress ipaddress = Dns.GetHostEntry("roku.bump.us");
            //IPEndPoint remoteEP = new IPEndPoint(ipaddress, 8060);
            //Socket sender = new Socket(AddressFamily.InterNetwork, 
            //    SocketType.Stream, ProtocolType.Tcp );

        }

    }
}
