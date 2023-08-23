using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginatingEFCore
{
    public class Controller
    {
        public void programflow()
        {
            Query query1 = new Query();

            int pageNumber = 1;
            int pageSize = 4;

            bool shouldContinue = true;

            while (shouldContinue) {
                Console.WriteLine("Display Records");
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter) {
                
                query1.FetchTours(pageNumber, pageSize);
                    pageNumber++;
                
                }
                else if (key.KeyChar == 'q')
                {
                    shouldContinue = false;
                }



            }
                


        }
    }
}
