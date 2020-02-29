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

namespace Menuer.Forms
{
    
    public partial class AddProduct : Form
    {
        

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataTable units = DBOps.ReadDB("SELECT Unit FROM Units");
            for (int i = 0; i < units.Rows.Count; i++)
            {
                cbUnits.Items.Add(units.Rows[i].ItemArray[0]);
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string name;
            string cals;
            string amount;
            string id;
            string cost;
            if (tbName.Text.Length > 0) name = tbName.Text; else name = "none";
            if (DBOps.isReal(tbCals.Text)) cals = tbCals.Text; else cals = "0.0";
            if (DBOps.isReal(tbAmount.Text)) amount = tbAmount.Text; else amount = "0.0";
            if (DBOps.isInteger(tbCost.Text)) cost= tbCost.Text; else cost= "0";
            if (cbUnits.Text != "") id = cbUnits.SelectedIndex.ToString(); else id = "0";
            string Query = $"INSERT INTO Products ('Name', 'Calories', 'Amount', 'UnitID', 'Cost') values" +
                $" ('{name}','{cals}','{amount}','{id}','{cost}')";
            DBOps.WriteDB(Query);
        }
    }
}
