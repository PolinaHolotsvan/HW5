using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Foods:Goods
    {
        private string expire;
        private double quantity;
        private string measurement;
        public void setExpire(string value)
        {
            expire = value;
        }
        public void setQuantity(double value)
        {
            quantity = value;
        }
        public void setMeasurement(string value)
        {
            measurement = value;
        }
        public string getExpire()
        {
            return expire;
        }
        public double getQuantity()
        {
            return quantity;
        }
        public string getMeasurement()
        {
            return measurement;
        }

    }
}
