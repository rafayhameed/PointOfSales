using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item
    {
        public string name;
        public int purchaseCost;
        public int SellingCost;
        public int quantity;
        public string itemCode;

        public Item(string nameParam, int purchaseParam, int SellingParam, int quantityParam, string itemCodeParam)
        {
            name = nameParam;
            purchaseCost = purchaseParam;
            SellingCost = SellingParam;
            quantity = quantityParam;
            itemCode = itemCodeParam;
        }
    }
}
