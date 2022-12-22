using System;

namespace LastHomeworkTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Daxil edin");
            var input = Console.ReadLine();
            int count = Convert.ToInt32(input);
            Employee[] workers = new Employee[count];
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{i + 1}-ci ishcinin adini soyadini daxil et:");
                string fullname = Console.ReadLine();

                Console.WriteLine($"{i + 1}-ci ishcinin yashini daxil et:");
                var num = Console.ReadLine();
                byte age = Convert.ToByte(num);

                Console.WriteLine($"{i + 1}-ci ishcinin mashini daxil et");
                var num1 = Console.ReadLine();
                double salary = Convert.ToDouble(num1);

                Console.WriteLine($"{i + 1}-ci ishcinin tutduqu vezifeni daxil et:");
                string position = Console.ReadLine();

                workers[i] = new Employee(fullname, age, salary, position);
            }

            Console.WriteLine("Butun Ishcilerin bilgileri");
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i].GetInfo());
            }

            string ans;

            do
            {
                Console.WriteLine("Axtarıs etmek isteyirsinizmi ? y / n");
                ans = Console.ReadLine();
                if (ans == "y")
                {
                    Console.WriteLine("Axtarish deyerini daxil edin");
                    string search = Console.ReadLine();
                    for (int i = 0; i < workers.Length; i++)
                    {
                        if (workers[i].FullName.Contains(search))
                        {
                            Console.WriteLine(workers[i].GetInfo());
                        }
                    }

                }



            }



            while (ans != "y"&& ans!="n");
        }
    }
}