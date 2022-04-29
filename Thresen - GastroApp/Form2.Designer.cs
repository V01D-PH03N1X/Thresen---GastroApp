namespace Thresen___GastroApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dlbl_welcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGrid_Orders = new System.Windows.Forms.DataGridView();
            this.tmr_5sec = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 437);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dlbl_welcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Startseite";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 3);
            this.panel1.TabIndex = 1;
            // 
            // dlbl_welcome
            // 
            this.dlbl_welcome.AutoSize = true;
            this.dlbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlbl_welcome.Location = new System.Drawing.Point(6, 3);
            this.dlbl_welcome.Name = "dlbl_welcome";
            this.dlbl_welcome.Size = new System.Drawing.Size(481, 33);
            this.dlbl_welcome.TabIndex = 0;
            this.dlbl_welcome.Text = "Herzlick Willkommen - Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGrid_Orders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Übersicht der Bestellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGrid_Orders
            // 
            this.DataGrid_Orders.AllowUserToAddRows = false;
            this.DataGrid_Orders.AllowUserToDeleteRows = false;
            this.DataGrid_Orders.AllowUserToOrderColumns = true;
            this.DataGrid_Orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGrid_Orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGrid_Orders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Orders.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_Orders.Name = "DataGrid_Orders";
            this.DataGrid_Orders.Size = new System.Drawing.Size(768, 408);
            this.DataGrid_Orders.TabIndex = 0;
            this.DataGrid_Orders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Orders_CellEndEdit);
            // 
            // tmr_5sec
            // 
            this.tmr_5sec.Enabled = true;
            this.tmr_5sec.Interval = 5000;
            this.tmr_5sec.Tick += new System.EventHandler(this.tmr_5sec_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "GastroApp - Thresen - Startseite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label dlbl_welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGrid_Orders;
        private System.Windows.Forms.Timer tmr_5sec;
    }
}