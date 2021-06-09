using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        public double TotalBillValue { get; set; }

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice) : base(iCode, iName)
        {
            ItemCode = iCode;
            ItemName = iName;
            ItemPrice = iPrice;
        }

        public override double PayPerPiece(int quantity)
        {
            return quantity * ItemPrice.FirstOrDefault(x => x.Key == ItemCode).Value;
        }

        public override double PayPerWeight(int weight)
        {
            return weight * ItemPrice.FirstOrDefault(x => x.Key == ItemCode).Value;
        }

        public double TaxOnTotalBill()
        {
            return 5.0;
        }


    }
}
