namespace Thresen___GastroApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.slbl_password = new System.Windows.Forms.Label();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.slbl_Username = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dbconn = new System.Windows.Forms.Button();
            this.tB_dbname = new System.Windows.Forms.TextBox();
            this.tB_dbpassword = new System.Windows.Forms.TextBox();
            this.slbl_dbname = new System.Windows.Forms.Label();
            this.slbl_dbpassword = new System.Windows.Forms.Label();
            this.tB_dbhostname = new System.Windows.Forms.TextBox();
            this.tB_dbuser = new System.Windows.Forms.TextBox();
            this.slbl_dbhostname = new System.Windows.Forms.Label();
            this.slbl_dbuser = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dlbl_debug = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Password);
            this.groupBox1.Controls.Add(this.slbl_password);
            this.groupBox1.Controls.Add(this.tB_Username);
            this.groupBox1.Controls.Add(this.slbl_Username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(144, 32);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(100, 20);
            this.tB_Password.TabIndex = 2;
            this.tB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Password_KeyPress);
            // 
            // slbl_password
            // 
            this.slbl_password.AutoSize = true;
            this.slbl_password.Location = new System.Drawing.Point(141, 16);
            this.slbl_password.Name = "slbl_password";
            this.slbl_password.Size = new System.Drawing.Size(50, 13);
            this.slbl_password.TabIndex = 2;
            this.slbl_password.Text = "Passwort";
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(9, 32);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(100, 20);
            this.tB_Username.TabIndex = 1;
            // 
            // slbl_Username
            // 
            this.slbl_Username.AutoSize = true;
            this.slbl_Username.Location = new System.Drawing.Point(6, 16);
            this.slbl_Username.Name = "slbl_Username";
            this.slbl_Username.Size = new System.Drawing.Size(75, 13);
            this.slbl_Username.TabIndex = 0;
            this.slbl_Username.Text = "Benutzername";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(21, 98);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "&Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dbconn);
            this.groupBox2.Controls.Add(this.tB_dbname);
            this.groupBox2.Controls.Add(this.tB_dbpassword);
            this.groupBox2.Controls.Add(this.slbl_dbname);
            this.groupBox2.Controls.Add(this.slbl_dbpassword);
            this.groupBox2.Controls.Add(this.tB_dbhostname);
            this.groupBox2.Controls.Add(this.tB_dbuser);
            this.groupBox2.Controls.Add(this.slbl_dbhostname);
            this.groupBox2.Controls.Add(this.slbl_dbuser);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datenbank - Optionen";
            // 
            // btn_dbconn
            // 
            this.btn_dbconn.Location = new System.Drawing.Point(6, 109);
            this.btn_dbconn.Name = "btn_dbconn";
            this.btn_dbconn.Size = new System.Drawing.Size(238, 23);
            this.btn_dbconn.TabIndex = 8;
            this.btn_dbconn.Text = "Test && &Save";
            this.btn_dbconn.UseVisualStyleBackColor = true;
            this.btn_dbconn.Click += new System.EventHandler(this.btn_dbconn_Click);
            // 
            // tB_dbname
            // 
            this.tB_dbname.Location = new System.Drawing.Point(144, 83);
            this.tB_dbname.Name = "tB_dbname";
            this.tB_dbname.Size = new System.Drawing.Size(100, 20);
            this.tB_dbname.TabIndex = 7;
            // 
            // tB_dbpassword
            // 
            this.tB_dbpassword.Location = new System.Drawing.Point(144, 44);
            this.tB_dbpassword.Name = "tB_dbpassword";
            this.tB_dbpassword.PasswordChar = '*';
            this.tB_dbpassword.Size = new System.Drawing.Size(100, 20);
            this.tB_dbpassword.TabIndex = 5;
            // 
            // slbl_dbname
            // 
            this.slbl_dbname.AutoSize = true;
            this.slbl_dbname.Location = new System.Drawing.Point(141, 67);
            this.slbl_dbname.Name = "slbl_dbname";
            this.slbl_dbname.Size = new System.Drawing.Size(86, 13);
            this.slbl_dbname.TabIndex = 2;
            this.slbl_dbname.Text = "Datenbankname";
            // 
            // slbl_dbpassword
            // 
            this.slbl_dbpassword.AutoSize = true;
            this.slbl_dbpassword.Location = new System.Drawing.Point(141, 28);
            this.slbl_dbpassword.Name = "slbl_dbpassword";
            this.slbl_dbpassword.Size = new System.Drawing.Size(50, 13);
            this.slbl_dbpassword.TabIndex = 2;
            this.slbl_dbpassword.Text = "Passwort";
            // 
            // tB_dbhostname
            // 
            this.tB_dbhostname.Location = new System.Drawing.Point(9, 83);
            this.tB_dbhostname.Name = "tB_dbhostname";
            this.tB_dbhostname.Size = new System.Drawing.Size(100, 20);
            this.tB_dbhostname.TabIndex = 6;
            // 
            // tB_dbuser
            // 
            this.tB_dbuser.Location = new System.Drawing.Point(9, 44);
            this.tB_dbuser.Name = "tB_dbuser";
            this.tB_dbuser.Size = new System.Drawing.Size(100, 20);
            this.tB_dbuser.TabIndex = 4;
            // 
            // slbl_dbhostname
            // 
            this.slbl_dbhostname.AutoSize = true;
            this.slbl_dbhostname.Location = new System.Drawing.Point(6, 67);
            this.slbl_dbhostname.Name = "slbl_dbhostname";
            this.slbl_dbhostname.Size = new System.Drawing.Size(89, 13);
            this.slbl_dbhostname.TabIndex = 0;
            this.slbl_dbhostname.Text = "Datenbankserver";
            // 
            // slbl_dbuser
            // 
            this.slbl_dbuser.AutoSize = true;
            this.slbl_dbuser.Location = new System.Drawing.Point(6, 28);
            this.slbl_dbuser.Name = "slbl_dbuser";
            this.slbl_dbuser.Size = new System.Drawing.Size(80, 13);
            this.slbl_dbuser.TabIndex = 0;
            this.slbl_dbuser.Text = "Datenbankuser";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(156, 98);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "B&eenden";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dlbl_debug
            // 
            this.dlbl_debug.AutoSize = true;
            this.dlbl_debug.Location = new System.Drawing.Point(18, 136);
            this.dlbl_debug.Name = "dlbl_debug";
            this.dlbl_debug.Size = new System.Drawing.Size(0, 13);
            this.dlbl_debug.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 158);
            this.Controls.Add(this.dlbl_debug);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GastroApp - Thresen - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Label slbl_password;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.Label slbl_Username;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dbconn;
        private System.Windows.Forms.TextBox tB_dbname;
        private System.Windows.Forms.TextBox tB_dbpassword;
        private System.Windows.Forms.Label slbl_dbname;
        private System.Windows.Forms.Label slbl_dbpassword;
        private System.Windows.Forms.TextBox tB_dbhostname;
        private System.Windows.Forms.TextBox tB_dbuser;
        private System.Windows.Forms.Label slbl_dbhostname;
        private System.Windows.Forms.Label slbl_dbuser;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label dlbl_debug;
    }
}

