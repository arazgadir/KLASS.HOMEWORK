using System;
using System.Security.Cryptography.X509Certificates;

namespace KLASS.ZADACHA4
{

                                       //    4. Создать класс Money, разработав следующие элементы класса:
                                       //Поля:
                                       //int first;//номинал купюры
                                       //    int second; //количество купюр
                                       //    Конструктор, позволяющий создать экземпляр класса с заданными значениям полей.
                                       //    Методы, позволяющие:
                                       //вывести номинал и количество купюр;
                                       //    определить, хватит ли денежных средств на покупку товара на сумму N рублей.
                                       //    определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.
                                       //    Свойства:
                                       //позволяющее получить-установить значение полей (доступное для чтения и записи);
                                       //    позволяющее рассчитать сумму денег(доступное только для чтения).

    class Money
    {

        private int first;
        private int second;

        public int First
        {
            set { first = value; }



            get { return first; }
        }
        public int Second
        {
            set { second = value; }



            get { return second; }
        }





        public int Summa
        { get
            { return (first * second);
            }
        }



        public Money()
        {

        }



        public Money(int a, int b)
        {
            first = a;
            second = b;

        }

        public void SumOfMoney ()
        {
            
            Console.WriteLine ("Сумма денег " + Summa + " манат");

        }


        public void  Bill ()
        {
            Console.WriteLine("Номинал: " + first + " манат");
            Console.WriteLine("Количество купюр: " + second);
        }

        public void  GetEnough ()
        {
          
            Console.WriteLine("Достаточноли у вас средств на покупку товаров. \n Наишите  цену товара: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if ((first * second) / c > 0)
            {
                Console.WriteLine("Денег хватает на покупку товара в " + c + " манат");
            }
            else
            {
                Console.WriteLine("Недостаточно денег");
            }
            

        }

        public void GetProduct()
        {

            Console.WriteLine("Какое количество товаров можно купуть на имеющиеся средства. \nВведите цену товара: ");
            double s = double.Parse(Console.ReadLine());
            

            double kolichestvo =  Math.Truncate( (first*second)/ s);

            Console.WriteLine ( kolichestvo + " штук товара можно купить");
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Money M = new Money();
            do 
            {

                Console.Write("Введите номинал купьюры: ");
                M.First = int.Parse(Console.ReadLine());

                Console.Write("Введите количество купьюр: ");
                M.Second = int.Parse(Console.ReadLine());

            }
            
            while (M.First <=0 || M.Second <=0);

            M.Bill();
            M.SumOfMoney();
                                      Console.WriteLine();
            M.GetEnough();
                                      Console.WriteLine();
            M.GetProduct();


        }
    }
}
