using System;

namespace EncasulationDemoWithDieClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);

            }
            
/*            Die die1 = new Die();
            //die1.Value =  cannot set value outside class
            Console.WriteLine(die1.Value);
            die1.Roll();
            Console.WriteLine(die1.Value);
            Console.ReadKey();
*/        }
    }
}
