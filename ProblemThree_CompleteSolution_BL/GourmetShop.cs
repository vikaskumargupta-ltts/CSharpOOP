using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public Dictionary<int,double> ItemPrice { get; set; }

        protected GourmetShop(int iCode,string iName)
        {
            ItemCode = iCode;
            ItemName = iName;
        }

        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}