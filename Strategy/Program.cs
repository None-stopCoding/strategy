using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static List<Line> lines = new List<Line>();
    
        public static char question()
        {
            Console.WriteLine();
            Console.WriteLine("1. Создать новую линию");
            Console.WriteLine("2. Вывести линии на экран");
            Console.WriteLine("3. Выход из программы");
            return Console.ReadLine()[0];
        }
        public static EndObject task()
        {
            Console.WriteLine();
            Console.WriteLine("1. Нет фигуры");
            Console.WriteLine("2. Стрелка");
            Console.WriteLine("3. Ромб");
            switch (Console.ReadLine()[0])
            {
                case '1':
                    {
                        return new EndObject(new None());
                    }
                case '2':
                    {
                        return new EndObject(new Arrow());
                    }
                case '3':
                    {
                        return new EndObject(new Romb());
                    }
            }
            return null;
        }
        public static void work()
        {
            char answer = question();
            while (answer != '3')
            {
                switch (answer)
                {
                    case '1':
                        {
                            Random rnd = new Random();
                            lines.Add(new Line(rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), task(), task()));
                            break;
                        }
                    case '2':
                        {
                            for (int i = 0; i < lines.Count; i++)
                            {
                                Console.WriteLine(i+1 + ") " + lines[i].showLine());
                            }
                            break;
                        }
                }
                answer = question();
            }
        }
        static void Main(string[] args)
        {
            work();
        }
    }
}
