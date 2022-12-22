using System;

namespace Exeption_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[4];
            notebooks[0] = new Notebook("HP", 670);
            notebooks[1] = new Notebook("MacBookPro", 2300);
            notebooks[2] = new Notebook("Asus ROG", 2600);
            notebooks[3] = new Notebook("MacAir", 3000);

            string opt;
            do
            {
                Console.WriteLine("1: Notbuklar uzerinde axtarish et:");
                Console.WriteLine("2: Yeni Notebook yarat: ");
                Console.WriteLine("0: menyudan cixish");

                opt = Console.ReadLine();
                if (opt == "1")
                {
                    Console.WriteLine("Axtarish edin:");
                    var search = Console.ReadLine();

                    var fillteredNoteBooks = SearchByName(notebooks, search);

                    NoteBookInfo(fillteredNoteBooks);
                }
                if (opt == "2")
                {
                    Console.WriteLine("Yeni Notebook yarat: ");

                    Notebook notebook = CreateNotebook();
                    
                    Add(notebooks, notebook);

                    NoteBookInfo(notebooks);
                   


                }






            } while (opt != "0");



            static void NoteBookInfo(Notebook[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].GetInfo());
                }
            }



            static Notebook[] SearchByName(Notebook[] arr, string search)
            {
                Notebook[] newArr = new Notebook[0];

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i].Name.ToLower().Contains(search) || arr[i].Name.Contains(search) || arr[i].Name.ToUpper().Contains(search))
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = arr[i];
                    }
                }
                return newArr;
            }


            static void Add(Notebook[] arr, Notebook value)
            {
                Notebook[] newArr = new Notebook[arr.Length + 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                newArr[arr.Length - 1] = value;

                arr = newArr;
            }

            static Notebook CreateNotebook()
            {
                Console.WriteLine("Notebook'un adi:");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {

                    throw new NotebookNameFormatException("Ad Null yada Space ola bilmez");

                }

                Console.WriteLine("Notebook'un Price:");
                var input = Console.ReadLine();
                double price = Convert.ToDouble(input);
                if (price <= 0)
                {
                    throw new NotebookNameFormatException("Price deyeri menfi yada sifira beraber ola bilmez");
                }

                Console.WriteLine("NoteBook'un RAM'i:");
                var inputb = Console.ReadLine();
                byte ram = Convert.ToByte(inputb);

                if (ram <= 0)
                {
                    throw new NotebookNameFormatException("RAM deyeri menfi yada sifira beraber ola bilmez");
                }

                Notebook notebook = new Notebook(name, price, ram);
               


                return notebook;
            }

        }


    }
}

