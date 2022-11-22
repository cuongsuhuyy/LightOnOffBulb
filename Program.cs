using System;
using System.Collections.Generic;

namespace LightOnOffExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue;
            int lightOn = 1;
            int lightOff = 0;
            do 
            {
                List<int> stateOfBulb = new List<int>();
                Console.Write("Vui long nhap so den: ");
                int bulb = int.Parse(Console.ReadLine());
                Console.Write("Vui long nhap so lan bat tat: ");
                int countTimesTurnOnOffOfBulb = int.Parse(Console.ReadLine());
                int currentTimesTurnOnOffBulb = countTimesTurnOnOffOfBulb;

                //Mac dinh den se o trang thai tat
                for (int i = 0; i < bulb - 1; i++)
                {
                    if (i == 0)
                    {
                        if (countTimesTurnOnOffOfBulb % 2 == 0) stateOfBulb.Add(lightOff);
                        else stateOfBulb.Add(lightOn);
                    }

                    currentTimesTurnOnOffBulb /= 2;
                    if (currentTimesTurnOnOffBulb % 2 == 0) stateOfBulb.Add(lightOff);
                    else stateOfBulb.Add(lightOn);
                }

                Console.Write("Trang thai cua bong den la: ");
                foreach (var item in stateOfBulb)
                {
                    Console.Write(item.ToString() + " ");
                }

                Console.Write("\nTiep tuc khong: 1 | co; 0 | khong: ");
                var _IsContinue = Console.ReadLine();
                if (_IsContinue == "1") isContinue = true;
                else isContinue = false;
                Console.Write("\n");
            } while (isContinue == true);
        }
    }
}
