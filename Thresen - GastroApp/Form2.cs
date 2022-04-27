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
        public Form2()
        {
            InitializeComponent();
            //on exit, close the application
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //on exit, close the application
            Application.Exit();
        }
    }
}
