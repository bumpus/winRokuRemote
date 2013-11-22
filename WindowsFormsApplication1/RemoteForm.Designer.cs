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
            this.btn_fwd = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.bnt_rev = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.bnt_instantReplay = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_fwd);
            this.tabPage1.Controls.Add(this.btn_play);
            this.tabPage1.Controls.Add(this.bnt_rev);
            this.tabPage1.Controls.Add(this.btn_info);
            this.tabPage1.Controls.Add(this.bnt_instantReplay);
            this.tabPage1.Controls.Add(this.btn_down);
            this.tabPage1.Controls.Add(this.btn_right);
            this.tabPage1.Controls.Add(this.btn_left);
            this.tabPage1.Controls.Add(this.btn_select);
            this.tabPage1.Controls.Add(this.Up);
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
            // btn_fwd
            // 
            this.btn_fwd.Location = new System.Drawing.Point(169, 152);
            this.btn_fwd.Name = "btn_fwd";
            this.btn_fwd.Size = new System.Drawing.Size(75, 23);
            this.btn_fwd.TabIndex = 23;
            this.btn_fwd.Text = ">>";
            this.btn_fwd.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(88, 152);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 22;
            this.btn_play.Text = "||>";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // bnt_rev
            // 
            this.bnt_rev.Location = new System.Drawing.Point(7, 152);
            this.bnt_rev.Name = "bnt_rev";
            this.bnt_rev.Size = new System.Drawing.Size(75, 23);
            this.bnt_rev.TabIndex = 21;
            this.bnt_rev.Text = "<<";
            this.bnt_rev.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(169, 123);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 20;
            this.btn_info.Text = "*";
            this.btn_info.UseVisualStyleBackColor = true;
            // 
            // bnt_instantReplay
            // 
            this.bnt_instantReplay.Location = new System.Drawing.Point(7, 123);
            this.bnt_instantReplay.Name = "bnt_instantReplay";
            this.bnt_instantReplay.Size = new System.Drawing.Size(75, 23);
            this.bnt_instantReplay.TabIndex = 19;
            this.bnt_instantReplay.Text = "IR";
            this.bnt_instantReplay.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(88, 94);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 18;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(169, 65);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 17;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(7, 65);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 16;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(88, 65);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 15;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(88, 36);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 14;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(8, 7);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(170, 8);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "192.168.0.16",
            "192.168.0.20"});
            this.comboBox1.Location = new System.Drawing.Point(16, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "RemoteForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoteForm_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_fwd;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button bnt_rev;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button bnt_instantReplay;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}

