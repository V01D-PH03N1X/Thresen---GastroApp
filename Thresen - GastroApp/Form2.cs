using MySql.Data.MySqlClient;
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
        GastroApp gastroApp = Form1.gastroApp;
        


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
            lines = gastroApp.LoadLogin();
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
                //e.Handled = true;
                gastroApp.exit();
            }

            if (e.KeyCode == Keys.F10)  //Get Table on Press F10
            {
                DataSet ds = new DataSet();
                ds = gastroApp.SQL_GetOrders("Trinken");
                if (ds != null)
                    //Fill DataGrid_Orders with data from SQL
                    DataGrid_Orders.DataSource = ds.Tables[0];
                    
            }
        }

        private void tmr_5sec_Tick(object sender, EventArgs e)
        {
            DataGrid_Orders.Refresh();
            DataSet ds = new DataSet();
            ds = gastroApp.SQL_GetOrders("Trinken");
            //Check if there are new orders

            if (ds != null)
                //Update DataGrid_Orders with data from SQL
                DataGrid_Orders.DataSource = ds.Tables[0];


            try
            {
                DataGrid_Orders.Columns[0].ReadOnly = true;
                DataGrid_Orders.Columns[1].ReadOnly = true;
                DataGrid_Orders.Columns[2].ReadOnly = true;
                DataGrid_Orders.Columns[3].ReadOnly = false;
                DataGrid_Orders.Columns[4].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            tmr_5sec.Start();
            ds = gastroApp.SQL_GetOrders("Trinken");
            DataGrid_Orders.DataSource = ds.Tables[0];
        }

        private void DataGrid_Orders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Wenn das Dritte feld ausgewählt wurde
            if (e.ColumnIndex == 3)
            {
                // Get rowindex from DataGrid_Orders
                int rowIndex = e.RowIndex;
                DataGridViewRow cell = DataGrid_Orders.Rows[rowIndex];
                int isChecked;
                if ((bool) cell.Cells[3].Value)
                    isChecked = 1;
                else
                    isChecked = 0;
                int id = (int)cell.Cells[0].Value;
                gastroApp.SQL_UpdateOrders(id, isChecked);


            }
        }
    }
}
