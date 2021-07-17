using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure Programs");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                    BalancingParanthesis.StackOperations stackOperations = new BalancingParanthesis.StackOperations();
                    bool result = stackOperations.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
