using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которое необходимо сгенерировать в файле");
            int i = Int32.Parse(Console.ReadLine());

            StreamWriter streamwriter = new StreamWriter("D:\\TestPoints.txt");
            Random random = new Random();

            //ниже 4 строки для углов прямоугольника, чтобы можно было определить для каждой точки внутри она или нет
            streamwriter.WriteLine("1 300.000 300.000");
            streamwriter.WriteLine("2 300.000 500.000");
            streamwriter.WriteLine("3 500.000 500.000");
            streamwriter.WriteLine("4 500.000 300.000");

            for (int j = 0; j < i - 4;)
            {
                bool isXInsidePolygon = false;
                bool isYInsidePolygon = false;

                streamwriter.Write(j + 5);
                streamwriter.Write(" ");
                int x = random.Next(0, 1000);
                streamwriter.Write(x);

                if (x > 299 && x < 500)
                {
                    isXInsidePolygon = true;
                }

                streamwriter.Write(".");
                streamwriter.Write(random.Next(0, 1000));
                streamwriter.Write(" ");
                int y = random.Next(0, 1000);
                streamwriter.Write(y);

                if (y > 299 && y < 500)
                {
                    isYInsidePolygon = true;
                }

                streamwriter.Write(".");
                streamwriter.Write(random.Next(0, 1000));

                if (isXInsidePolygon && isYInsidePolygon)
                {
                    streamwriter.WriteLine(" True");
                }
                else
                {
                    streamwriter.WriteLine(" False");
                }

                j++;
            }

            streamwriter.Close();
        }
    }
}
