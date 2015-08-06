using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SelfHostingTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int Addition(int number1, int number2);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int Subtraction(int number1, int number2);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int Multiplication(int number1, int number2);
        
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int Division(int number1, int number2);
    }

    [DataContract]
    public class ExceptionMessage
    {
        private string infoExceptionMessage;
        public ExceptionMessage(string Message)
        {
            this.infoExceptionMessage = Message;
        }
        [DataMember]
        public string errorMessageOfAction
        {
            get { return this.infoExceptionMessage; }
            set { this.infoExceptionMessage = value; }
        }
    }
}
