using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuer
{
    class Product
    {
        
        private int id;
        private string name;
        private double calories; // KCalories per 100g of product
        private double amount; // Full weight of product
        private int unit; //Unit of Measure
        private double weight; //total weight
        private double localWeight; //using weight
        private bool used;
        private double importance; //Importance of product in recipe
        private int cost; //cost per unit
        private int[] times;
        public Product()
        {
            times = new int[3];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = 0;
            }
            used = false;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int[] Times
        {
            get { return times; }
            set { times = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public double LocalWeight
        {
            get { return localWeight; }
            set { localWeight = value; }
        }
        public bool Used
        {
            get { return used; }
            set { used = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Importance
        {
            get { return importance; }
            set { importance = value; }
        }
        public int Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        } 
        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        

    }
}
