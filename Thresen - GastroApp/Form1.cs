using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Thresen___GastroApp
{
    public partial class Form1 : Form
    {
        public GastroApp gastroApp = new GastroApp();
        string[] login;
        
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

        }
    }
    public class GastroApp
    {
        string db_user, db_pass, db_host, db_name; //Datenbank-Verbindungsdaten
        
        public void SQL_GetLogin(string user, string pass, string host, string name) 
        {
            db_user = user; //Setzen der Verbindungsdaten
            db_pass = pass;
            db_host = host; 
            db_name = name;
        }


        public bool SQL_Login(string user, string pass)
        {
            bool login = false; //Ergebnis der Login-Prüfung

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection("Server=" + db_host + ";Database=" + db_name + ";Uid=" + db_user + ";Pwd=" + db_pass + ";");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Accounts WHERE Name = '" + user + "' AND Password = '" + pass + "'", conn);
            try
            {
                conn.Open();    //Öffnen der Verbindung
                MySqlDataReader reader = cmd.ExecuteReader();   //Ausführen des SQL-Commands
                if (reader.HasRows) //Prüfung ob ein Datensatz gefunden wurde
                {
                    login = true;   //Login erfolgreich
                }
                else
                {
                    login = false;  //Login fehlgeschlagen
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);    //Fehlermeldung ausgeben wenn ein Fehler auftritt
            }
            finally
            {
                conn.Close();   //Schließen der Verbindung
            }
            return login;   //Ergebnis der Login-Prüfung zurückgeben
        }

        public void SQL_SaveLogin(string user, string pass, string host, string name, string username)
        {
            //Save Login to File
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //create Folder if not exists
            if (!System.IO.Directory.Exists(path + "\\GastroApp"))
            {
                System.IO.Directory.CreateDirectory(path + "\\GastroApp");
            }
            //create File and write to it
            System.IO.File.WriteAllText(path + "\\GastroApp\\lastlogin.dat", "### Logindaten der Letzen Verbindung ### \n!!! DO NOT CHANGE ANYTHING !!! \n"+ host + "\n" + name+ "\n" + user + "\n" + pass + "\n" + username);
        }
        public string[] SQL_LoadLogin()
        {
            string[] lines;
            //Check if File exists
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (System.IO.File.Exists(path + "\\GastroApp\\lastlogin.dat"))
            {
                //Read File
                 lines = System.IO.File.ReadAllLines(path + "\\GastroApp\\lastlogin.dat");
                return lines;
            }
            //set first index of lines to "empty"
            lines = new string[1];
            lines[0] = "empty";
            //return lines
            return lines;
        }
        public void exit()
        {
            //Sicherstellung der Beendung des Programmes
            DialogResult result = MessageBox.Show("Bist du sicher, dass du das Programm beenden willst?", "Beenden", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
