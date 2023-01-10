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
        StreamWriter streamwriter = new StreamWriter("D:\\TestPoints.txt");
        Random random = new Random();

        public void Start()
        {
            //не уверен, что нужно, поэтому не делал. но можно будет добавить метод с указанием пути к файлу для записи
            UserInput();
            PointsOfPolygon();
            RandomPoints();
        }

        private void UserInput()
        {
            Console.WriteLine("Введите количество строк, которое необходимо сгенерировать в файле");
            numberOfLines = Int32.Parse(Console.ReadLine());
        }

        private void PointsOfPolygon()
        {
            //ниже 4 строки для углов прямоугольника, чтобы можно было определить для каждой точки внутри она или нет
            //В дальнейшем в этом методе можно сделать ввод произвольных углов прямоугольника
            streamwriter.WriteLine("1 300.000 300.000");
            streamwriter.WriteLine("2 300.000 800.000");
            streamwriter.WriteLine("3 800.000 800.000");
            streamwriter.WriteLine("4 800.000 300.000");
        }

        private void RandomPoints()
        {
            for (int j = 0; j < numberOfLines - 4;)
            {
                bool isXInsidePolygon = false;
                bool isYInsidePolygon = false;

                streamwriter.Write(j + 5);
                streamwriter.Write(" ");
                int x = random.Next(0, 1000);
                streamwriter.Write(x);

                if (x > 299 && x < 800)
                {
                    isXInsidePolygon = true;
                }

                streamwriter.Write(".");
                streamwriter.Write(random.Next(0, 1000));
                streamwriter.Write(" ");
                int y = random.Next(0, 1000);
                streamwriter.Write(y);

                if (y > 299 && y < 800)
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
