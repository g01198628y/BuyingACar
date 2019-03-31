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
            var month = 0;
            var ratio = 1 - percentLossByMonth / 100;

            while (savingPerMonth + startPriceOld < startPriceNew)
            {
                month++;
                if (month % 2 == 0)
                {
                    ratio -= 0.005;
                }

                startPriceOld = (int)(startPriceOld * ratio);
                startPriceNew = (int)(startPriceNew * ratio);

                var leftMoney = month * savingPerMonth + startPriceOld - startPriceNew;
                if (leftMoney > 0)
                {
                    return new[] { month, leftMoney };
                }
            }
            return new[] { 0, startPriceOld - startPriceNew };
        }
    }
}