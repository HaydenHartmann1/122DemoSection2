
namespace Hunting_The_Manticore_lvl_14
{
    public class Delete
    {

        private int num1 = int.MaxValue;
        private double num2 = double.MaxValue;
        private string name = "n/a";
        private static int count = 0;

        public Delete(string name, int num1, double num2)
        {
            this.name = name;
            this.num1 = num1;
            this.num2 = num2;
            count++;
        }

        public int GetCount
        {
            get { return count; }
        }
        public int Num1
        {
            get { return this.num1; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Value must be > 0");
                }
                else
                {
                    this.num1 = value;
                }
            }
        }


    }
}
