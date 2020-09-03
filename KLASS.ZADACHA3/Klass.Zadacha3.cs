using System;

namespace KLASS.ZADACHA3
{
    //    3 .Создать класс Rectangle, разработав следующие элементы класса:                                           
    //Поля:                                                                                                           
    //int a, b;                                                                                                       
    //    Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.                               
    //    Методы, позволяющие:                                                                                        
    //вывести длины сторон прямоугольника на экран;                                                                   
    //    рассчитать периметр прямоугольника;                                                                         
    //рассчитать площадь прямоугольника.                                                                              
    //Свойства:                                                                                                       
    //получить-установить длины сторон прямоугольника(доступное для чтения и записи);                                 
    //    позволяющее установить, является ли данный прямоугольник квадратом(доступное только для чтения).            


    class Rectangle
    {



        private int a;


        private int b;                                 // polya

        public int StoronaA
        {
            set { a = value; }



            get { return a; }
        }
        public int StoronaB
        {
            set { b = value; }



            get { return b; }
        }



        public string Again
        {
            get
            {
                if (a <= 0 || b <= 0)
                {
                   return "Неверные параметры. Введите заново.\n";
                }
                else
                {
                    return "Отлично. Параметры верные\n";
                }

            }

        }






        public Rectangle()
        {


        }


        public Rectangle(int A, int B)                               //konstruktor
        {
            a = A;
            b = B;
        }


        public void GetFrontSize()
        {
            Console.WriteLine("Длина стороны - a: " + a + " м");
            Console.WriteLine("Длина стороны - b: " + b + " м");
        }


        public int GetPerimetr()
        {
            int p = 2 * (a + b);
            return p;
            //Console.WriteLine("Периметр: " + p + " м");
        }

        public void GetArea()
        {
            Console.WriteLine("Площадь: " + (a * b) + " квадратных м.");

        }


    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Rectangle R = new Rectangle();



            do


            {
                //Console.WriteLine();
                Console.Write("Введите сторону - a: ");
                R.StoronaA = int.Parse(Console.ReadLine());


                Console.Write("Введите сторону - b: ");
                R.StoronaB = int.Parse(Console.ReadLine());

                Console.WriteLine(R.Again);
                //Console.WriteLine();

            } while (R.StoronaA <= 0 || R.StoronaB <= 0);

            Console.WriteLine();

            R.GetFrontSize();

            Console.WriteLine();

            Console.WriteLine("Периметр: " + R.GetPerimetr() + " м");
            R.GetArea();

        }
    }
}
