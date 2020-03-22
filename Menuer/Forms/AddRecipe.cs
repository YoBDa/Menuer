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
        DataTable unitsTable = new DataTable();
        DataTable productsTable = new DataTable();
        DataTable categoriesTable = new DataTable();

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
            if (!double.TryParse(tbAmount.Text, out double amount)) 
            {
                MessageBox.Show("Неверное количество!", "Внимание!");
                return;
            }
            int importance = (int)nudImportance.Value;
            
            
            if (name == "" || amount == 0 || (importance < 0 && importance > 100))
            {
                MessageBox.Show("Неверные данные продукта!", "Внимание!");
                return;

            } //проверка на пустоту
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    products[i].Used = true;
                    products[i].Importance = importance;
                    products[i].LocalWeight = amount;
                    string conf = $"{products[i].Name} x {amount} {Measures[products[i].Unit]}, важность {importance}%";
                    lbProducts.Items.Add(conf);
                     
                }
            }

        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {
            string productsQuery = "SELECT ID, Name, Calories, Amount, UnitID, Cost FROM Products";
            string categoryQuery = "SELECT ID, Category FROM Categories";
            string unitsQuery = "SELECT ID,Unit FROM Units";
            unitsTable = DBOps.ReadDB(unitsQuery);
            categoriesTable = DBOps.ReadDB(categoryQuery);
            productsTable = DBOps.ReadDB(productsQuery);
            products = new Product[productsTable.Rows.Count];
            for (int i = 0; i < products.Length; i++)
            {
                
                products[i] = new Product();
                cbName.Items.Add(productsTable.Rows[i].ItemArray[1]);
                products[i].ID = (int)productsTable.Rows[i].ItemArray[0];
                products[i].Name = productsTable.Rows[i].ItemArray[1].ToString();
                products[i].Calories = (double)productsTable.Rows[i].ItemArray[2];
                products[i].Amount = (double)productsTable.Rows[i].ItemArray[3];
                products[i].Unit = (int)productsTable.Rows[i].ItemArray[4];
                products[i].Cost = (int)productsTable.Rows[i].ItemArray[5];
            }
            for (int i = 0; i < categoriesTable.Rows.Count; i++)
            {
                cbCategory.Items.Add(categoriesTable.Rows[i].ItemArray[1]);
            }

            
        }

        private void BtAddRecipe_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "") { MessageBox.Show("Имя не может быть пустым.", "Ошибка");  return; } 
            if (!cbEvening.Checked & !cbMorning.Checked & !cbNoon.Checked) { MessageBox.Show("Выберите хоть одно время суток.", "Ошибка"); return; }
            if (lbProducts.Items.Count == 0) { MessageBox.Show("В рецепте должен быть хотя бы один продукт.", "Ошибка"); return; }
            if (cbCategory.SelectedItem == null) { MessageBox.Show("Выберите категорию.", "Ошибка"); return; }
            string RecipeName = tbName.Text;
            bool[] Times = { cbMorning.Checked, cbNoon.Checked, cbEvening.Checked };
            string RecipeText = tbDescription.Text;
            string RecipeQuery = $"INSERT INTO Recipes ('Name','RecipeText','isMorning','isNoon','isEvening')" +
                $"VALUES ('{RecipeName}','{RecipeText}','{Times[0]}','{Times[1]}','{Times[2]}')"; // Sending recipe to db
            DBOps.WriteDB(RecipeQuery);
            DataTable cache = DBOps.ReadDB("SELECT ID FROM Recipes");
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

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.Refresh();
        }

        private void BtRemoveProduct_Click(object sender, EventArgs e)
        {
            object SI = lbProducts.SelectedItem;
            if (SI != null)
            {
                int fi = SI.ToString().IndexOf('x');
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].Name == SI.ToString().Substring(0, fi-1))
                    {
                        products[i].Used = false;
                        lbProducts.Items.Remove(SI);

                    }
                }
            }
        }

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == cbName.Text) id = products[i].Unit;
            }
            lbUnit.Text = unitsTable.Rows[id - 1].ItemArray[1].ToString();
        }
    }
}
