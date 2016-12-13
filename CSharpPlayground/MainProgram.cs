using System;

namespace C_Sharp_Sample_Code_Test
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Delegates d = new Delegates();

            //Console.WriteLine("==== Using Normal Delegates ====");
            //d.UseDelegate();

            //Console.WriteLine(Environment.NewLine + "==== Using Action<> Delegates ====");
            //d.calc(3, 4);

            //Console.WriteLine(Environment.NewLine + "==== Testing Events ====");
            //Pub p = new Pub();
            //p.CreateAndRaise();

            //Console.WriteLine(Environment.NewLine + SampleTask.TaskTest());

            //Console.ReadKey();

            int[] nums = { 2, 1, 9, 4, 4, 56, 90, 3 };
            int target = 8;

            var twoSum = new Solution().TwoSum(nums, target);

            Console.WriteLine($" First Index: {twoSum[0]} {Environment.NewLine} Second Index: {twoSum[1]}");
            Console.ReadKey();

        }
    }

    public class Pub
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += () => Console.WriteLine("Event 1");

            p.OnChange += () => Console.WriteLine("Event 2");

            p.Raise();
        }
    }

}
