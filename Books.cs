using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Books:Goods
    {
        private int pageNum;
        private string publisher;
        private string authors;
        public void setAuthors(string value)
        {
            authors = value;
        }
        public string getAuthors() {
            return authors; 
        }
        public void setPublisher(string value)
        {
            publisher = value;
        }
        public string getPublisher()
        {
            return publisher;
        }
        public int getPageNum()
        {
            return pageNum;
        }
        public void setPageNum(int value)
        {
            pageNum = value;
        }

    }
}
