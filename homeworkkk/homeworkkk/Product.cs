using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkkk
{
    class Product
    {
        public string _name;
        public int _price;

        public int _count;
        public int _totalincome;
        public Product(string name,int price,int count,  int totalincome)
        {
             _name = name;
            _price = price;
           _count = count;
            _totalincome = totalincome;
        }

        public void sell()
        {
            while( _count < 0)
            {
                _count--;
                _totalincome  += _price;

            }
            Console.WriteLine( _totalincome);
        }


       
    }
}
