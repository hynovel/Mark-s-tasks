using System;


namespace Simple_Currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                
                    Console.WriteLine("Hello this is currency converter written by Vlad ." +
                    " Do you want to continue? Y/N?");
                    string Continue = Console.ReadLine();
                    if (Continue == "Y" || Continue == "y" || Continue == "yes" || Continue == "Yes")
                    {




                    }
                    else
                    {
                        Console.WriteLine(" Press enter and try over agian ");
                        Console.ReadLine();
                        continue;


                    }



                try
                {
                    Console.WriteLine("Enter amount in USD ");

                    double USD = double.Parse(Console.ReadLine());


                    Console.WriteLine("What is the rate for NZD?");
                    double UsdToNzd;

                    UsdToNzd = double.Parse(Console.ReadLine());

                    Console.WriteLine("What is the rate for KZT?");
                    double UsdToKzt = double.Parse(Console.ReadLine());

                    Console.WriteLine("What is the rate for RUB?");
                    double UsdToRub = double.Parse(Console.ReadLine());

                    double Kzt = USD * UsdToKzt;
                    double Nzd = USD * UsdToNzd;
                    double Rub = USD * UsdToRub;


                    Console.WriteLine(USD + " in NZD " + Nzd);
                    Console.WriteLine(USD + " in KZT " + Kzt);
                    Console.WriteLine(USD + " in RUB " + Rub);

                    while (true)
                    {


















                        Console.WriteLine("Do you want to enter new amount? Y/N");
                        string Continue2 = Console.ReadLine();
                        if (Continue2 == "Y" || Continue2 == "y" || Continue2 == "yes" || Continue2 == "Yes")
                        {




                        }

                        else
                        {
                            Console.WriteLine("Error");
                            return;
                        }

                        Console.WriteLine("Now I want you to do something with amounts you've got" + " Chose next action: from Kaz, Nz or Usa ");

                        string action = Console.ReadLine();


                        switch (action)
                        {

                            case "Kaz":
                                Console.WriteLine(Kzt + Nzd);
                                break;
                            case "Nz":
                                Console.WriteLine(Kzt + Rub);
                                break;
                            case "Usa":
                                Console.WriteLine(Kzt + USD);
                                break;
                            default:
                                Console.WriteLine("Another error");
                                break;


                        }

                        Console.ReadLine();
                        Console.Clear();






                    }


                }

                    catch (Exception)
                {
                    Console.WriteLine("Error. Press enter and try agian ");
                    Console.ReadLine();
                    continue;
                }

            }




            









        }

            







        
    }
}
