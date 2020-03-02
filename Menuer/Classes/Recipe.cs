using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menuer
{
    class Recipe
    {
        private string name;
        private double calories; // KCalories per 100g of product
        private Product[] Products;
        private double[] weights;
        private double[] importances;
        private int cookingTime;
        private int category;
        public Recipe()
        {

        }
        public int Category
        {
            get { return category; }
            set
            {
                try
                {
                    if (value > 5) throw new Exception("Wrong category ID");
                    else category = value;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка");
                }
            } 
        }
        public int CookingTime
        {
            get { return cookingTime; }
            set { cookingTime = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Calories
        {
            get { return calories; }
        }
        /*
        
         */

    }
}
