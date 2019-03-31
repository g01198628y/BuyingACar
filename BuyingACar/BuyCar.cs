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
            if (startPriceOld >= startPriceNew)
            {
                return new[] { 0, startPriceOld - startPriceNew };
            }

            var month = 0;
            var ratio = 1 - percentLossByMonth / 100;
            int leftMoney;

            do
            {
                month++;
                if (month % 2 == 0)
                {
                    ratio -= 0.005;
                }

                startPriceOld = (int)(startPriceOld * ratio);
                startPriceNew = (int)(startPriceNew * ratio);

                leftMoney = month * savingPerMonth + startPriceOld - startPriceNew;
                if (leftMoney > 0)
                {
                    return new[] { month, leftMoney };
                }
            } while (leftMoney <= 0);
            return new[] { 0, 0 };
        }
    }
}