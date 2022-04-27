using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thresen___GastroApp
{
    public partial class Form2 : Form
    {
        GastroApp gastroApp = new GastroApp();
        string[] lines;
        public Form2()
        {
            InitializeComponent();
            //on exit, close the application
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            //Block alt + f4
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lines = gastroApp.SQL_LoadLogin();
            string username = lines[6];
            //Set dlbl_welcome to Welcome Username with first letter capitalized
            dlbl_welcome.Text = "Herzlich Willkommen - " + username[0].ToString().ToUpper() + username.Substring(1)+"!";
            

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //on exit, close the application
            Application.Exit();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //block alt + f4
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                gastroApp.exit();
            }
        }
    }
}
