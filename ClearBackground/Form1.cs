using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClearBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            string path = @"C:\Users\d1mon\Desktop\testCoordinates.txt"; //Файл с которого считываютья данные.
            string showResult = @"C:\Users\d1mon\Desktop\TestClearBackground.txt"; //Файл в который записывается точка находиться внутри прямоугольника или нет.
            PointF points = new PointF(101.5f, 200.0f);
            PointF[] polygons = new PointF[4];
           
            using (StreamReader read = new StreamReader(path))
            {
                string[] allLine;
                int index = 0;
                allLine = File.ReadAllLines(path);

                foreach (string currentLine in allLine)
                {
                    string[] coordinatesX = new string[12];
                    string[] coordinatesY = new string[12];

                    string[] splitCoordinates = currentLine.Split(',');
                    coordinatesX[index] = splitCoordinates[0];
                    coordinatesY[index] = splitCoordinates[1];

                    if (index > 3)
                    {
                        points.X = Convert.ToUInt64(coordinatesX[index]);
                        points.Y = Convert.ToUInt64(coordinatesY[index]);
                        IsPointInPolygon4(polygons, points);

                        using (FileStream file = new FileStream(showResult, FileMode.Append))
                        using (StreamWriter writer = new StreamWriter(file))
                            writer.WriteLine(result);
                    }
                    else
                    {
                        polygons[index].X = Convert.ToUInt64(coordinatesX[index]);
                        polygons[index].Y = Convert.ToUInt64(coordinatesY[index]);
                    }
                    
                    index++;
                }

                Close();
            }

            bool IsPointInPolygon4(PointF[] currentPolygon, PointF currentPoint)
            {
                int j = currentPolygon.Count() - 1;
                for (int i = 0; i < currentPolygon.Count(); i++)
                {
                    if (currentPolygon[i].Y < currentPoint.Y && currentPolygon[j].Y >= currentPoint.Y || currentPolygon[j].Y < currentPoint.Y && currentPolygon[i].Y >= currentPoint.Y)
                    {
                        if (currentPolygon[i].X + (currentPoint.Y - currentPolygon[i].Y) / (currentPolygon[j].Y - currentPolygon[i].Y) * (currentPolygon[j].X - currentPolygon[i].X) < currentPoint.X)
                        {
                            result = !result;
                        }
                    }
                    j = i;
                }
                return result;
            }
        }
    }
}
