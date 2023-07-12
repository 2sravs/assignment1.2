using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conassign_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "20";
                int ConvertedNumber = Convert.ToInt32(input);
                Console.WriteLine(",convert number is: \t" + ConvertedNumber);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
