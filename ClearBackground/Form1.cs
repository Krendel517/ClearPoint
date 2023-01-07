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
            DirectoryInfo personalPath = new DirectoryInfo(Path.Text);
            string path = Convert.ToString(personalPath); 
            string showResult = @"C:\Users\d1mon\Desktop\TestClearBackground.txt";
            PointF[] polygons = new PointF[4];
           
            using (StreamReader read = new StreamReader(path))
            {
                string[] allLine;
                allLine = File.ReadAllLines(path);

                for (int i = 0; i < allLine.Length; i++)
                {
                    string[] splitCoordinates = allLine[i].Split(',');
                    float coordinatesX = Convert.ToUInt64(splitCoordinates[0]);
                    float coordinatesY = Convert.ToUInt64(splitCoordinates[1]);

                    if (i > 3)
                    {
                        PointF point = new PointF(coordinatesX, coordinatesY);
                        bool result = IsPointInPolygon4(polygons, point);

                        using (FileStream file = new FileStream(showResult, FileMode.Append))
                        using (StreamWriter writer = new StreamWriter(file))
                            writer.WriteLine(result);
                    }
                    else
                    {
                        polygons[i].X = coordinatesX;
                        polygons[i].Y = coordinatesY;
                    }   
                }
                Close();
            }
        }

        private bool IsPointInPolygon4(PointF[] currentPolygon, PointF currentPoint)
        {
            bool result = false;
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
