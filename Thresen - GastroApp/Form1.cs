using System;
using System.Windows.Forms;


namespace Thresen___GastroApp
{
    public partial class Form1 : Form
    {
        public GastroApp gastroApp = new GastroApp();
        string[] login;
        public void Login()
        {
            string dbuser = tB_dbuser.Text.ToString();
            string dbpassword = tB_dbpassword.Text.ToString();
            string dbhostname = tB_dbhostname.Text.ToString();
            string dbname = tB_dbname.Text.ToString();
            string username = tB_Username.Text.ToString();

            gastroApp.SQL_GetLogin(dbuser, dbpassword, dbhostname, dbname);
            if (gastroApp.SQL_Login(tB_Username.Text.ToString(), tB_Password.Text.ToString()))
            {
                gastroApp.SQL_SaveLogin(dbuser, dbpassword, dbhostname, dbname, username);
                //hide Form1 and show Form2
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                //Message box with text "Login fehlgeschlagen!"
                MessageBox.Show(this, "Login fehlgeschlagen!", "Login fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            //block alt + f4
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = gastroApp.SQL_LoadLogin();
            //Check if lines is empty
            if (login[0] == "empty")
            {
                MessageBox.Show(this, "Aufgrund keiner Vorherigen LoginSessions konnten keine Daten geladen werden!", "NO LOGINS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tB_dbhostname.Text = login[2];
                tB_dbuser.Text = login[3];
                tB_dbname.Text = login[4];
                tB_dbpassword.Text = login[5];
                tB_Username.Text = login[6];
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            gastroApp.exit();
        }

        private void btn_dbconn_Click(object sender, EventArgs e)
        {

            //Setzen der Verbindungsdaten
            string dbuser = tB_dbuser.Text.ToString();
            string dbpassword = tB_dbpassword.Text.ToString();
            string dbhostname = tB_dbhostname.Text.ToString();
            string dbname = tB_dbname.Text.ToString();
            string username = tB_Username.Text.ToString();

            gastroApp.SQL_GetLogin(dbuser, dbpassword, dbhostname, dbname); //Setzen der Verbindungsdaten
            if (gastroApp.SQL_Login(tB_Username.Text.ToString(), tB_Password.Text.ToString()))
            {
                MessageBox.Show("Login erfolgreich!");
                //save to File
                gastroApp.SQL_SaveLogin(dbuser, dbpassword, dbhostname, dbname, username);
            }
            else
            {
                MessageBox.Show("Login fehlgeschlagen!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //block alt + f4
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                //POPUP with text "so nicht mein freund!"
                MessageBox.Show(this, "So nicht mein Freund!", "Nicht mein Freund!");


                e.Handled = true;
                gastroApp.exit();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
    
}
