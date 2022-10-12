using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Foods:Goods
    {
        private string _expireTime;
        private double _quantity;
        private string _measurementUnit;

        public string ExpireTime { get { return _expireTime; } set { _expireTime = value; } }
        public double Quantity { get { return _quantity; } set { _quantity = value; } }
        public string MeasurementUnit { get { return _measurementUnit; } set { _measurementUnit = value;} }
        

    }
}
