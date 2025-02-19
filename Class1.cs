using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM_ACT9
{
    internal class Class1
    {

        public double[,] frappePrices = { {130, 145, 155 },
                                          {140, 155, 165 },
                                          {140, 155, 165 },
                                          {145, 160, 170 }
                                                        };

        public double[,] HotPrices = { {120, 130, 140 },
                                       {120, 140, 150 },
                                       {135, 145, 155 },
                                       {140, 150, 160 }
                                                        };

        public double[] pastryPrices = { 80, 100, 80, 90, 85, 120 };

        public double computePriceQty(int x, int y, int qty, string type)
        {
            double total = 0;
            if (type == "Frappe")
            {
                total += frappePrices[x, y] * qty;
            }

            else
            {
                total += HotPrices[x, y] * qty;
            }

            return total;
        }


        public double vat;
        public double vatable;

        public double computedTotal(Label l1, Label l2, Label l3, double p1, double p2, double p3, double p4, double p5)
        {
            double total = p1+p2+p3+p4+p5;
            l3.Text = total.ToString() + ".00";

            vat = Math.Round (total * 0.12, 2);
            l2.Text = vat.ToString();

            vatable = total - vat;
            l1.Text = vatable.ToString();


            return total;
        }

 

    }
}
