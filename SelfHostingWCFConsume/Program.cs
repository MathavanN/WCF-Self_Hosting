using SelfHostingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostingWCFConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceConsume();
        }
        public static void ConsoleClose()
        {
            Console.WriteLine("Are you sure to close the application? (1/0)\n");
            string close = Console.ReadLine();
            if (close == "1")
            {
                Console.Clear();
                WCFServiceConsume();
            }
        }
        public static void WCFServiceConsume()
        {
            try
            {
                Console.WriteLine("Self-Hosting a WCF Service in Console Application\n");
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("Enter first integer number : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second integer number : ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                SelfHostingTest.Service1 wcfService = new SelfHostingTest.Service1();

                try
                {
                    int addition = wcfService.Addition(number1, number2);
                    Console.WriteLine("Addition Result : " + addition);
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    Console.WriteLine("Addition Service Error : " + exceptionFromService.Detail.errorMessageOfAction);
                }

                try
                {
                    int subtraction = wcfService.Subtraction(number1, number2);
                    Console.WriteLine("Subtraction Result : " + subtraction);
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    Console.WriteLine("Subtraction Service Error : " + exceptionFromService.Detail.errorMessageOfAction);
                }

                try
                {
                    int multiplication = wcfService.Multiplication(number1, number2);
                    Console.WriteLine("Multiplication Result : " + multiplication);
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    Console.WriteLine("Multiplication Service Error : " + exceptionFromService.Detail.errorMessageOfAction);
                }

                try
                {
                    int division = wcfService.Division(number1, number2);
                    Console.WriteLine("Division Result : " + division);
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    Console.WriteLine("Division Service Error : " + exceptionFromService.Detail.errorMessageOfAction);
                }
                Console.WriteLine("*********************************\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadKey(); 
            }
            finally
            {
                ConsoleClose();
            }
        }
    }
}
