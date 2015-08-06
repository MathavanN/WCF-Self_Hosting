using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SelfHostingTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Addition(int number1, int number2)
        {
            try
            {
                return number1 + number2;
            }
            catch (Exception exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }

        public int Subtraction(int number1, int number2)
        {
            try
            {
                if (number1 > number2)
                {
                    return number1 - number2;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }

        public int Multiplication(int number1, int number2)
        {
            try
            {
                return number1 * number2;
            }
            catch (Exception exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }

        public int Division(int number1, int number2)
        {
            try
            {
                if (number2 != 0)
                {
                    return number1 / number2;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }
    }
}
