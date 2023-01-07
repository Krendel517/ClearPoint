using System;
using System.Collections.Generic;
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
            PointF point = new PointF(0,0);
            PointF[] polygon = new PointF[4];
           
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
                        point.X = Convert.ToInt32(coordinatesX[index]);
                        point.Y = Convert.ToInt32(coordinatesY[index]);
                        IsPointInPolygon4(polygon, point);

                        using (FileStream file = new FileStream(showResult, FileMode.Append))
                        using (StreamWriter writer = new StreamWriter(file))
                            writer.WriteLine(result);     
                    }
                    else
                    {
                        polygon[index].X = Convert.ToInt32(coordinatesX[index]);
                        polygon[index].Y = Convert.ToInt32(coordinatesY[index]);
                    }
                    
                    index++;
                }

                Close();
            }

            bool IsPointInPolygon4(PointF[] currentPolygon, PointF currentPoint)
            {
                int i, j;
                int nvert = currentPolygon.Length;
                for (i = 0, j = nvert - 1; i < nvert; j = i++)
                {
                    if (((currentPolygon[i].Y > currentPoint.Y) != (currentPolygon[j].Y > currentPoint.Y)) &&
                     (currentPoint.X < (currentPolygon[j].X - currentPolygon[i].X) * (currentPoint.Y - currentPolygon[i].Y) / (currentPolygon[j].Y - currentPolygon[i].Y) + currentPolygon[i].X))
                        result = !result;
                }
                return result;
            }
        }
    }
}
