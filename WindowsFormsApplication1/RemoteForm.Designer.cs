namespace WindowsFormsApplication1
{
    partial class RemoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fwd = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_rev = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_instantReplay = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRoku = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 233);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_fwd);
            this.tabPage1.Controls.Add(this.btn_play);
            this.tabPage1.Controls.Add(this.btn_rev);
            this.tabPage1.Controls.Add(this.btn_info);
            this.tabPage1.Controls.Add(this.btn_instantReplay);
            this.tabPage1.Controls.Add(this.btn_down);
            this.tabPage1.Controls.Add(this.btn_right);
            this.tabPage1.Controls.Add(this.btn_left);
            this.tabPage1.Controls.Add(this.btn_select);
            this.tabPage1.Controls.Add(this.btn_up);
            this.tabPage1.Controls.Add(this.btn_back);
            this.tabPage1.Controls.Add(this.btn_home);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // btn_fwd
            // 
            this.btn_fwd.Location = new System.Drawing.Point(169, 152);
            this.btn_fwd.Name = "btn_fwd";
            this.btn_fwd.Size = new System.Drawing.Size(75, 23);
            this.btn_fwd.TabIndex = 23;
            this.btn_fwd.Text = ">>";
            this.btn_fwd.UseVisualStyleBackColor = true;
            this.btn_fwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_fwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(88, 152);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 22;
            this.btn_play.Text = "||>";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_rev
            // 
            this.btn_rev.Location = new System.Drawing.Point(7, 152);
            this.btn_rev.Name = "btn_rev";
            this.btn_rev.Size = new System.Drawing.Size(75, 23);
            this.btn_rev.TabIndex = 21;
            this.btn_rev.Text = "<<";
            this.btn_rev.UseVisualStyleBackColor = true;
            this.btn_rev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_rev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(169, 123);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 20;
            this.btn_info.Text = "*";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_instantReplay
            // 
            this.btn_instantReplay.Location = new System.Drawing.Point(7, 123);
            this.btn_instantReplay.Name = "btn_instantReplay";
            this.btn_instantReplay.Size = new System.Drawing.Size(75, 23);
            this.btn_instantReplay.TabIndex = 19;
            this.btn_instantReplay.Text = "IR";
            this.btn_instantReplay.UseVisualStyleBackColor = true;
            this.btn_instantReplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_instantReplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(88, 94);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 18;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(169, 65);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 17;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(7, 65);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 16;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(88, 65);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 15;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_select.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(88, 36);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 14;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(8, 7);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(170, 8);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonPress);
            this.btn_home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onRemoteButtonRelease);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Channels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbRoku
            // 
            this.cbRoku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoku.FormattingEnabled = true;
            this.cbRoku.Items.AddRange(new object[] {
            "192.168.0.16",
            "192.168.0.20"});
            this.cbRoku.Location = new System.Drawing.Point(16, 250);
            this.cbRoku.Name = "cbRoku";
            this.cbRoku.Size = new System.Drawing.Size(260, 21);
            this.cbRoku.TabIndex = 14;
            this.cbRoku.SelectedIndex = 0;
            // 
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.cbRoku);
            this.Controls.Add(this.tabControl1);
            this.Name = "RemoteForm";
            this.Text = "winRokuRemote";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_fwd;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_rev;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_instantReplay;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbRoku;
        private System.Windows.Forms.Label label1;


    }
}

