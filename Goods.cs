using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Goods
    {
        protected double _price;
        protected string _country;
        protected DateTime _date;
        protected string _name;
        protected string _description;

        public double Price { get { return _price; } set { _price = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }

    }
}
