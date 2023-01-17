using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoints
{
    class Program
    {
        int numberOfLines;
        StreamWriter streamWriter = new StreamWriter("D:\\TestPoints.txt");
        Random random = new Random();

        public void Start()
        {
            UserInput();
            RandomPoints();
        }

        private void UserInput()
        {
            Console.WriteLine("Введите количество строк, которое необходимо сгенерировать в файле");
            numberOfLines = Int32.Parse(Console.ReadLine());
        }

        private void RandomPoints()
        {
            for (int j = 0; j < numberOfLines;)
            {
                bool isXInsidePolygon = false;
                bool isYInsidePolygon = false;

                streamWriter.Write(j + 1);
                streamWriter.Write(" ");
                int x = random.Next(0, 1000);
                streamWriter.Write(x);

                if (x >= 300 && x <= 800)
                {
                    isXInsidePolygon = true;
                }

                streamWriter.Write(".");
                streamWriter.Write(random.Next(0, 1000));
                streamWriter.Write(" ");
                int y = random.Next(0, 1000);
                streamWriter.Write(y);

                if (y >= 300 && y <= 800)
                {
                    isYInsidePolygon = true;
                }

                streamWriter.Write(".");
                streamWriter.Write(random.Next(0, 1000));

                if (isXInsidePolygon && isYInsidePolygon)
                {
                    streamWriter.WriteLine(" True");
                }
                else
                {
                    streamWriter.WriteLine(" False");
                }

                j++;
            }

            streamWriter.Close();
        }
    }
}
