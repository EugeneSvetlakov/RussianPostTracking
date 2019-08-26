using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussianPostTracking.ruPost;

namespace RussianPostTracking
{
    public class PostalTracking
    {
        AuthorizationHeader authorization { get; set; }
        OperationHistoryRequest request { get; set; }

        public PostalTracking()
        {
            
            
        }


        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // http://www.compilemode.com/2016/03/calling-web-service-using-soap-request-without-wsdl-and-endpoints.html
            // https://victorz.ru/20180805729
            OperationHistory12 operation = new OperationHistory12();
            AuthorizationHeader authorization = new AuthorizationHeader
            {
                mustUnderstand = "1",
                login = "HXkJjcymqMqwBh",
                password = "Ry65q1pxuWf6"
            };
            OperationHistoryRequest request = new OperationHistoryRequest
            {
                MessageType = 0,
                Barcode = "22221312123123"
            };
            var res = operation.getOperationHistory(
                request
                , authorization
                );
            
            
            Console.Write(res.ToString());
            Console.ReadKey();
        }
    }
}
