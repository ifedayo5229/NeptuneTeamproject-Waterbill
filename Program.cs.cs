using System;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerIdNumber, customerName;
            double consumedUnit = 0;
            double userBill = 0;
            double totalBill = 0.00;
            double percentageSurcharge = 0.15;
            double chargeRate = 0.00;
            double calculatedSurcharge = 0.00;


            Console.WriteLine("Welcome to Team Neptune Unit Price Calculator.");
            Console.Write("Please enter your Name :  ");
            customerName = Console.ReadLine();
            Console.Write("Please enter your Id Number :  ");
            customerIdNumber = Console.ReadLine();
            Console.Write("Please enter your unit consumed :  ");
            

            while (true)
            {
                try
                {

                    consumedUnit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    break;
                }
              
                    if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerIdNumber))
                    {
                        Console.WriteLine("Please fill in all fields as they are required.\n Thank you.");
                        break;
                    }
                
               

            if (consumedUnit < 200)
                {
                    userBill = consumedUnit * 1.20;
                    chargeRate = 1.20;
                }
                else if (consumedUnit >= 200 && consumedUnit < 400)
                {
                    userBill = consumedUnit * 1.50;
                    chargeRate = 1.50;

                }
                else if (consumedUnit >= 400 && consumedUnit < 600)
                {
                    userBill = consumedUnit * 1.80;
                    chargeRate = 1.80;
                }
                else if (consumedUnit >= 600)
                {
                    userBill = consumedUnit * 2.00;
                    chargeRate = 2.00;
                }

                if (userBill >= 300)
                {
                    calculatedSurcharge = (userBill * percentageSurcharge);
                    totalBill = userBill + calculatedSurcharge;
                }
                else if (userBill >= 100 && userBill < 300)
                {
                    totalBill = userBill;
                }

                //Output
                Console.WriteLine($"\nCustomer IDNO : {customerIdNumber}");
                Console.WriteLine($"Customer Name : {customerName}");
                Console.WriteLine($"Unit Consumed : {consumedUnit}");
                Console.WriteLine($"Amount Charges @ {chargeRate} per unit : {userBill}");
                Console.WriteLine($"Surcharge Amount : {calculatedSurcharge}");
                Console.WriteLine($"Net Amount Paid By The Customer : {totalBill}");
                Console.WriteLine("Thank You.\n");


                if (userBill < 100)
                {
                    Console.WriteLine($"The minimum acceptable bill is #100 but your bill is {userBill}\n");
                    break;
                }
                break;
            }
        }
    }
}
