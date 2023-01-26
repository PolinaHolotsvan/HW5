using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Books:Goods
    {
        private int _pageNum;
        private string _publisher;
        private string _authors;

        public int PageNum { get { return _pageNum; } set { _pageNum = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public string Authors { get { return _authors; } set { _authors = value; } }

    }
}
