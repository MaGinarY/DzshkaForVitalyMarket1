namespace DzshkaForVitalyMarket1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the brand that you prefere:");

            Console.WriteLine("1. AMD");
            Console.WriteLine("2. Nvidia");
            Console.WriteLine("3. IntelGraphics");

            string brandString = Console.ReadLine();

            int brand = Convert.ToInt32(brandString);

            switch (brand)
            {
                case 1:
                    Console.WriteLine("You've choosed AMD");
                    break;
                case 2:
                    Console.WriteLine("You've choosed Nvidia");
                    break;
                case 3:
                    Console.WriteLine("You've choosed IntelGraphics");
                    Console.WriteLine("Oh, man you did wrond choise, go back again");
                    break;
                default:
                    Console.WriteLine("I'm sorry, we don't have any brands");
                    break;

            }


            if (brand == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Please, then enter the model of your videocard");
                Console.WriteLine("1. Radeon RX");
                Console.WriteLine("2. Radeon R7");
                Console.WriteLine("3. Radeon R9");
                Console.WriteLine("4. Radeon RX Vega");
                Console.WriteLine("5. Radeon HD");

                string modelAmdString = Console.ReadLine();
                int modelAmd = Convert.ToInt32(modelAmdString);

                switch (modelAmd)
                {

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("Radeon RX 7900 XTX for 900$");
                        Console.WriteLine("Radeon RX 570 for 200$");
                        Console.WriteLine("Radeon RX 470 for 149$");
                        Console.WriteLine("Radeon RX 580 for 249$");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("Radeon R7 265 for 149$");
                        Console.WriteLine("Radeon R7 260X for 139$");
                        Console.WriteLine("Radeon R7 250 for 99$");
                        Console.WriteLine("Radeon R7 240 for 49$");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("Radeon R9 Fury X for 299$");
                        Console.WriteLine("Radeon R9 Nano for 139$");
                        Console.WriteLine("Radeon R9 390 for 149$");
                        Console.WriteLine("Radeon R9 290X for 89$");
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("Radeon RX Vega 64 499$");
                        Console.WriteLine("Radeon RX Vega 56 399$");
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("Radeon HD 6750 for 299$");
                        Console.WriteLine("Radeon HD 7970 for 399$");
                        Console.WriteLine("Radeon HD 6950 for 199$");
                        break;
                    default:
                        Console.WriteLine("We don't have any different models");
                        break;
                }
            }




            if (brand == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Please, then enter the model of your videocard");
                Console.WriteLine("1. GT");
                Console.WriteLine("2. GTX");
                Console.WriteLine("3. RTX");

                string modelNvidiaString = Console.ReadLine();
                int modelNvidia = Convert.ToInt32(modelNvidiaString);


                switch (modelNvidia)
                {

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("GT 480 for 39$");
                        Console.WriteLine("GT 580 for 69$");
                        Console.WriteLine("GT 440 for 29$");
                        Console.WriteLine("GT 1030 for 249$");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("GTX 1060 6GB for 149$");
                        Console.WriteLine("GTX 1050TI for 199$");
                        Console.WriteLine("GTX 580TI for 99$");
                        Console.WriteLine("GTX 1070 for 399$");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("We have these video cards for you:");
                        Console.WriteLine("RTX 2060S for 299$");
                        Console.WriteLine("RTX 3070 for 499$");
                        Console.WriteLine("RTX 3050 for 249$");
                        Console.WriteLine("RTX 2080 for 399$");
                        break;
                    default:
                        Console.WriteLine("We don't have any different models");
                        break;
                }
            }
        }
    }
} 
