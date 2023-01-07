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
            string path = @"C:\Users\d1mon\Desktop\testCoordinates.txt";
            string showResult = @"C:\Users\d1mon\Desktop\TestClearBackground.txt";
            PointF point = new PointF(101.5f, 200.0f);
            PointF[] pointPolygon = new PointF[4];
           
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
                        point.X = Convert.ToUInt64(coordinatesX[index]);
                        point.Y = Convert.ToUInt64(coordinatesY[index]);
                        IsPointInPolygon4(pointPolygon, point);

                        using (StreamWriter writer = new StreamWriter(showResult))
                            writer.Write(result);
                    }
                    else
                    {
                        pointPolygon[index].X = Convert.ToUInt64(coordinatesX[index]);
                        pointPolygon[index].Y = Convert.ToUInt64(coordinatesY[index]);
                    }
                    
                    index++;
                }

                Close();
            }

            bool IsPointInPolygon4(PointF[] polygon, PointF testPoint)
            {
                int j = polygon.Count() - 1;
                for (int i = 0; i < polygon.Count(); i++)
                {
                    if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                    {
                        if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
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
