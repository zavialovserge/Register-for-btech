using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_Goods
{
    class Goods
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { value = name; }
        }

        private float amount;
        public float Amount
        {
            get { return amount; }
            set { value = amount; }
        }
        private float procurementPrice;
        public float ProcurementPrice
        {
            get { return procurementPrice; }
            set { value = procurementPrice; }
        }

        private string categoryOfGoods;
        public string CategoryOfGoods
        {
            get { return categoryOfGoods; }
            set { value = categoryOfGoods; }
        }
        public Goods() { }
        public Goods(string _name, float _amount, float _procurementPrice, string _categoryOfGoods)
        {
            name = _name;
            amount = _amount;
            procurementPrice = _procurementPrice;
            categoryOfGoods = _categoryOfGoods;
        }
    }
}
