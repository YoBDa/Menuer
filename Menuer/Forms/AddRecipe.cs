using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menuer.Forms
{
    public partial class AddRecipe : Form
    {
        Product[] products;
        DataTable productsTable= new DataTable();

        public AddRecipe()
        {
            InitializeComponent();
        }

        private void BtAddProduct_Click(object sender, EventArgs e)
        {
            DataTable units = DBOps.ReadDB("SELECT Unit FROM Units");
            string[] Measures = new string[units.Rows.Count];
            for (int i = 0; i < units.Rows.Count; i++)
            {
                Measures[i] = units.Rows[i].ItemArray[0].ToString();
            }
            string name = cbName.Text;
            if (!double.TryParse(tbAmount.Text, out double amount)) return;
            if (!double.TryParse(tbImportace.Text, out double importance)) return;
            if (name == "" || amount == 0 || (importance < 0 && importance > 100)) return;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    products[i].Used = true;
                    products[i].Importance = importance;
                    products[i].LocalWeight = amount;
                    string conf = $"{products[i].Name}x{amount} {Measures[products[i].Unit]}, важность {importance}%";
                    lbProducts.Items.Add(conf);
                     
                }
            }

        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {
            string productsQuery = "SELECT ID, Name, Calories, Amount, UnitID, Cost FROM Products";
            productsTable = DBOps.ReadDB(productsQuery);
            products = new Product[productsTable.Rows.Count];
            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
                cbName.Items.Add(productsTable.Rows[i].ItemArray[1]);
                products[i].Name = productsTable.Rows[i].ItemArray[1].ToString();
                products[i].Calories = (double)productsTable.Rows[i].ItemArray[2];
                products[i].Amount = (double)productsTable.Rows[i].ItemArray[3];
                products[i].Unit = int.Parse(productsTable.Rows[i].ItemArray[4].ToString());
                products[i].Cost = int.Parse(productsTable.Rows[i].ItemArray[5].ToString());

            }
            
        }

        private void BtAddRecipe_Click(object sender, EventArgs e)
        {
            string RecipeName = tbName.Text;
            bool[] Times = { cbMorning.Checked, cbNoon.Checked, cbEvening.Checked };
            string RecipeText = tbDescription.Text;
            string RecipeQuery = $"INSERT INTO Recipe ('Name','RecipeText','isMorning','isNoon','isEvening')" +
                $"VALUES ('{RecipeName}','{RecipeText}','{Times[0]}','{Times[1]}','{Times[2]}')";
            DBOps.WriteDB(RecipeQuery);
            DataTable cache = DBOps.ReadDB("SELECT ID FROM Recipe");
            string recipeid = cache.Rows[cache.Rows.Count - 1].ItemArray[0].ToString();
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Used)
                {
                    string importance = products[i].Importance.ToString();
                    string localWeight = products[i].LocalWeight.ToString();
                    string productid = products[i].ID.ToString();
                    string WeightsQuery = $"INSERT INTO Weights ('RecipeID','ProductID','Weight','Importance')" +
                        $"VALUES('{recipeid}','{productid}','{localWeight}','{importance}')";
                    DBOps.WriteDB(WeightsQuery);
                }
            }


        }
    }
}
