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
            if (startPriceOld > startPriceNew)
            {
                return new[] { 0, startPriceOld - startPriceNew };
            }

            var month = 0;
            var totalSaving = 0;

            month += 1;
            totalSaving += savingPerMonth;
            startPriceOld = (int)(startPriceOld * (1 - (percentLossByMonth / 100)));
            startPriceNew = (int)(startPriceNew * (1 - (percentLossByMonth / 100)));
            var left = totalSaving + startPriceOld - startPriceNew;

            return new[] { month, left };
        }
    }
}