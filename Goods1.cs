using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Goods
    {
        protected double price;
        private string country;
        private DateTime date;
        
        private string name;

        private string description;
        
        public void setPrice(double value) { price = value; }
        public double getPrice() { return price; }
        public string getCountry() { return country; }
        public string getName() { return name; }
        public string getDescription() { return description; }
        public void setCountry(string value) { country = value; }
        public void setName(string value) { name = value; }
        public void setDescription(string value) { description = value; }
        public void setDate(DateTime value) { date = value; }
        public DateTime getDate() { return date; } 
    }
}
