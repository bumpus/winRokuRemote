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
            String command = "keydown/" + DetermineButton(sender);// +" HTTP/1.0\r\n";
            label1.Text = command;
            SendHTTPCommand(command);
        }

        private void onRemoteButtonRelease(object sender, MouseEventArgs e)
        {
            String command = "keyup/" + DetermineButton(sender);// + " HTTP/1.0\r\n";
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
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://192.168.0.16:8060/"+command);
            HttpWebResponse resp;
            req.Method= "POST";
            resp = (HttpWebResponse)req.GetResponse();

        }

    }
}
