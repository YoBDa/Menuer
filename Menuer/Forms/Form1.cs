using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Menuer.Forms;


namespace Menuer
{
    
    public partial class Form1 : Form
    {
        public string version = "v0.1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Menuer {version}";
            string SQLQuery = "DELETE FROM Products WHERE name = 'none'";
            DBOps.DeleteFromDB(SQLQuery);

        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form addProduct = new AddProduct();
            addProduct.Show();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addRecipe = new AddRecipe();
            addRecipe.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide()
                ;
        }
    }
}
