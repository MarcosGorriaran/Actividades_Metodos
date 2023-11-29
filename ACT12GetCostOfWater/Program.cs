using System;

namespace ACT12
{
    public class ACT12
    {
        public static void Main()
        {
            const int LimitAmountFreeWater = 50;
            const int LimitAmountWaterMinPrice = 200;
            const int DecimalLimitForEuro = 2;
            const float FixedPriceToPay = 6;
            const float StartPrice = 0;
            const float MinPrice = 0.1f;
            const float MaxPrice = 0.3f;
            const string AskAmountWaterUsed = "Cuantos litros de agua has usado: ";
            const string ShowFinalPrice = "Tendra que pagar la siguiente cantidad: ";

            int waterUsed;
            float cost = FixedPriceToPay;

            Console.Write(AskAmountWaterUsed);
            waterUsed = Convert.ToInt32(Console.ReadLine());

            Console.Write(ShowFinalPrice);
            //Numeros flotantes no funcionan bien, se requiere redondear.
            Console.Write(Math.Round(WaterCost(waterUsed, FixedPriceToPay, StartPrice, LimitAmountFreeWater, MinPrice, LimitAmountWaterMinPrice,MaxPrice),DecimalLimitForEuro));
        }

        public static float WaterCost(int amountWater, float fixedPrice, float increase, int firstIncrease, float firstCostIncrease, int secondIncrease, float secondCostIncrease)
        {
            float finalCost = fixedPrice;
            float costIncrease = increase;

            for(int i = 1; i <= amountWater; i++)
            {
                finalCost += costIncrease;
                if(i==firstIncrease)
                {
                    costIncrease = firstCostIncrease;
                }
                if (i == secondIncrease)
                {
                    costIncrease = secondCostIncrease;
                }
            }

            return finalCost;
        }
    }
}