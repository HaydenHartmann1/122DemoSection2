/*
    Hayden Hartmann
    1/29/2025
    Hunting The Manticore : And Practice
*/

namespace Hunting_The_Manticore_lvl_14
{
    public class BossBattle
    {
        public static void Main(string[] args)
        {
            Delete delete = new Delete("hayden", 5, 8);

            Console.WriteLine(delete.GetCount);
            
            Console.WriteLine(delete.Num1);

            delete.Num1 = -1;

            Console.WriteLine(delete.Num1);

            Console.ReadKey();
        }
    }
}








