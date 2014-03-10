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
        public RemoteForm()
        {
            InitializeComponent();
            RemoveCursorNavigation(this.tabControl1.Controls);
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
            //This method is very simple and does not check for errors. Consequence of things going wrong will be a program crash.
            //The command protocol is very simple, we are expecting a 200 response with 0 content length, so I'm not doing anything
            //to process the response, but asking for it. The Post is URL encoded, so the content length on the POST is also 0 (per default).
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://"+cbRoku.Text+":8060/"+command);
            HttpWebResponse resp;
            req.Method= "POST";
            resp = (HttpWebResponse)req.GetResponse();
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

    }
}
