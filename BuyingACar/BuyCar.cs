using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingACar
{
    public class BuyCar
    {
        public static int[] NbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            return new[] { 0, startPriceOld - startPriceNew };
        }
    }
}