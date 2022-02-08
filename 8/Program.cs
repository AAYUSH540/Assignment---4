using System;
using MEmp;
namespace MainProgram {
    class Program {
        public static void Main(string[] args) {
            Permanentemployee e1 = new Permanentemployee("Aayush", "Fadia", "10/12/2010", "9/2/2024", 70000.0, 10000, 4000, 2000);
            Console.WriteLine($"FIRST EMPLOYEE INFORMATION :\n{e1}");
            e1.giveRaise(10.0);
            Console.WriteLine($"FIRST EMPLOYEE INFORMATION AFTER 10% RAISE :\n{e1}");
            Permanentemployee e2 = new Permanentemployee("Lelouch", "Britania", "31/3/2012", "25/07/2027", 50000.0, 4000, 1500, 5000);
            Console.WriteLine($"SECOND EMPLOYEE INFORMATION :\n{e2}");
            e2.giveRaise(10.0);
            Console.WriteLine($"SECOND EMPLOYEE INFORMATION AFTER 10% RAISE :\n{e2}");
        }
    }
}