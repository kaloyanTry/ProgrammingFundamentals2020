using System;

namespace EquipmentPadawan
{
    class Equipment
    {
        static void Main(string[] args)
        {
            double amounMoney = double.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            int freeBeslts = 0;
            int moreLightsabers = 0;

            moreLightsabers = (int)Math.Ceiling(studentsNum + (studentsNum * 0.1));

            int studentsFreeBelts = studentsNum;

            do
            {
                if (studentsFreeBelts % 6 == 0)
                {
                    freeBeslts += 1;
                }
                studentsFreeBelts--;

            } while (studentsFreeBelts >= 6);
            
            double sumEquipmentn = 0;

            sumEquipmentn = (priceLightsabers * moreLightsabers) + (priceRobes * studentsNum) + (priceBelts * (studentsNum - freeBeslts));

            if (amounMoney >= sumEquipmentn)
            {
                Console.WriteLine($"The money is enough - it would cost {sumEquipmentn:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(sumEquipmentn - amounMoney):F2}lv more.");
            }

        }
    }
}
