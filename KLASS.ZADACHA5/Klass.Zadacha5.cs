using System;
using System.Security.Cryptography.X509Certificates;

namespace CLASS.ZADACHA5
{



    //{5. Создать класс для работы с одномерным массивом целых чисел.Разработать следующие элементы класса:
    //Поля:
    //int[] IntArray;
    //int n.
    //Конструктор, позволяющий создать массив размерности n.
    //Методы, позволяющие:
    //ввести элементы массива с клавиатуры;
    //вывести элементы массива на экран;
    //отсортировать элементы массива в порядке возрастания.
    //Свойства:
    //возвращающее размерность массива (доступное только для чтения);
    //позволяющее умножить все элементы массива на скаляр(доступное только для записи).




    class Massiv
    {

        public int[] Array { set; get; }

        public int n { set; get; }

        public int Size 

        {
            get { return n; }
        }

        public Massiv() { }


        public Massiv(int a)
        {
            a = n;
            int[] Array = new int[a];
        }


        public void GetElement()
        {


            int[] Array = new int[n];
            Console.WriteLine("Введите элементы массива\n");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}-й элемент: ", i + 1);
                Array[i] = Int32.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("элементы массива в порядке возрастания: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }


        }


    }


    class Program
    {
        static void Main(string[] args)


        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Massiv M = new Massiv();

            Console.Write("Введите количество элементов: ");
            M.n = int.Parse(Console.ReadLine());

            Console.WriteLine( "Размер массива: " +  M.Size + "\n");

            M.GetElement();

            //M.Bub();

        }
    }
}
