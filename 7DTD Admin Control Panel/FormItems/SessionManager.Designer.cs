namespace _7DTD_Admin_Control_Panel.FormItems
{
    partial class SessionManager
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
            this.textBox_FilterSession = new System.Windows.Forms.TextBox();
            this.listBox_Session = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Remote_Comment = new System.Windows.Forms.TextBox();
            this.textBox_Remote_ServerDisplayName = new System.Windows.Forms.TextBox();
            this.textBox_Remote_Host = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Remote_Port = new System.Windows.Forms.TextBox();
            this.textBox_Remote_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Local_Comment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Local_ConfigFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Local_Find = new System.Windows.Forms.Button();
            this.textBox_Local_ServerPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FilterSession
            // 
            this.textBox_FilterSession.Location = new System.Drawing.Point(12, 12);
            this.textBox_FilterSession.Name = "textBox_FilterSession";
            this.textBox_FilterSession.Size = new System.Drawing.Size(334, 20);
            this.textBox_FilterSession.TabIndex = 0;
            // 
            // listBox_Session
            // 
            this.listBox_Session.FormattingEnabled = true;
            this.listBox_Session.Location = new System.Drawing.Point(12, 38);
            this.listBox_Session.Name = "listBox_Session";
            this.listBox_Session.Size = new System.Drawing.Size(334, 251);
            this.listBox_Session.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(352, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 279);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote Server (Telnet)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Remote_Comment);
            this.groupBox1.Controls.Add(this.textBox_Remote_ServerDisplayName);
            this.groupBox1.Controls.Add(this.textBox_Remote_Host);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Remote_Port);
            this.groupBox1.Controls.Add(this.textBox_Remote_Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 234);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server Display Name :";
            // 
            // textBox_Remote_Comment
            // 
            this.textBox_Remote_Comment.Location = new System.Drawing.Point(124, 117);
            this.textBox_Remote_Comment.Multiline = true;
            this.textBox_Remote_Comment.Name = "textBox_Remote_Comment";
            this.textBox_Remote_Comment.Size = new System.Drawing.Size(281, 102);
            this.textBox_Remote_Comment.TabIndex = 22;
            // 
            // textBox_Remote_ServerDisplayName
            // 
            this.textBox_Remote_ServerDisplayName.Location = new System.Drawing.Point(124, 13);
            this.textBox_Remote_ServerDisplayName.Name = "textBox_Remote_ServerDisplayName";
            this.textBox_Remote_ServerDisplayName.Size = new System.Drawing.Size(281, 20);
            this.textBox_Remote_ServerDisplayName.TabIndex = 17;
            // 
            // textBox_Remote_Host
            // 
            this.textBox_Remote_Host.Location = new System.Drawing.Point(124, 39);
            this.textBox_Remote_Host.Name = "textBox_Remote_Host";
            this.textBox_Remote_Host.Size = new System.Drawing.Size(281, 20);
            this.textBox_Remote_Host.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Comment  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Host :";
            // 
            // textBox_Remote_Port
            // 
            this.textBox_Remote_Port.Location = new System.Drawing.Point(124, 65);
            this.textBox_Remote_Port.Name = "textBox_Remote_Port";
            this.textBox_Remote_Port.Size = new System.Drawing.Size(281, 20);
            this.textBox_Remote_Port.TabIndex = 19;
            // 
            // textBox_Remote_Password
            // 
            this.textBox_Remote_Password.Location = new System.Drawing.Point(124, 91);
            this.textBox_Remote_Password.Name = "textBox_Remote_Password";
            this.textBox_Remote_Password.Size = new System.Drawing.Size(281, 20);
            this.textBox_Remote_Password.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Port :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_Local_Comment);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_Local_ConfigFile);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button_Local_Find);
            this.tabPage2.Controls.Add(this.textBox_Local_ServerPath);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_Local_Comment
            // 
            this.textBox_Local_Comment.Location = new System.Drawing.Point(81, 66);
            this.textBox_Local_Comment.Multiline = true;
            this.textBox_Local_Comment.Name = "textBox_Local_Comment";
            this.textBox_Local_Comment.Size = new System.Drawing.Size(336, 102);
            this.textBox_Local_Comment.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Comment  :";
            // 
            // textBox_Local_ConfigFile
            // 
            this.textBox_Local_ConfigFile.Location = new System.Drawing.Point(81, 40);
            this.textBox_Local_ConfigFile.Name = "textBox_Local_ConfigFile";
            this.textBox_Local_ConfigFile.Size = new System.Drawing.Size(144, 20);
            this.textBox_Local_ConfigFile.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Config File :";
            // 
            // button_Local_Find
            // 
            this.button_Local_Find.Location = new System.Drawing.Point(342, 10);
            this.button_Local_Find.Name = "button_Local_Find";
            this.button_Local_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Local_Find.TabIndex = 2;
            this.button_Local_Find.Text = "Find ...";
            this.button_Local_Find.UseVisualStyleBackColor = true;
            // 
            // textBox_Local_ServerPath
            // 
            this.textBox_Local_ServerPath.Location = new System.Drawing.Point(81, 12);
            this.textBox_Local_ServerPath.Name = "textBox_Local_ServerPath";
            this.textBox_Local_ServerPath.Size = new System.Drawing.Size(255, 20);
            this.textBox_Local_ServerPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Server Path :";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(93, 297);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(12, 297);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 5;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(271, 297);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(623, 297);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(704, 297);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // SessionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 332);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox_Session);
            this.Controls.Add(this.textBox_FilterSession);
            this.Name = "SessionManager";
            this.Text = "Session Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FilterSession;
        private System.Windows.Forms.ListBox listBox_Session;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Remote_Comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Remote_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Remote_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Remote_Host;
        private System.Windows.Forms.TextBox textBox_Remote_ServerDisplayName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Local_Find;
        private System.Windows.Forms.TextBox textBox_Local_ServerPath;
        private System.Windows.Forms.TextBox textBox_Local_ConfigFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Local_Comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Cancel;
    }
}