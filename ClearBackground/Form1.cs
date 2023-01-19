using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClearBackground
{
    public partial class FormWindow : Form
    {
        private string resultPath;
        private PointF[] polygon;
        private int deleteChars;

        public FormWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPolygon();
            ChekAllPoints();
            deleteChars = Int32.Parse(txtDeleteChars.Text);
        }

        private string[] GetUserData(string path)
        {
            string[] allLines;
            allLines = File.ReadAllLines(path);
            return allLines;
        }

        private void SetPolygon()
        {
            string polygonPath = txtPolygonPath.Text;
            string[] lines = GetUserData(polygonPath);
            if (lines.Length < 3)
            {
                Console.WriteLine("Введите минимум 3 точки полигона.");
            }
            else
            {
                PointF[] newPolygon = new PointF[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] splitCoordinates = lines[i].Split(' ');
                    string coordX = splitCoordinates[2].Remove(0, deleteChars);
                    string coordY = splitCoordinates[3].Remove(0, deleteChars);
                    float coordinatesX = float.Parse(coordX, CultureInfo.InvariantCulture);
                    float coordinatesY = float.Parse(coordY, CultureInfo.InvariantCulture);
                    newPolygon[i].X = coordinatesX;
                    newPolygon[i].Y = coordinatesY;
                }

                polygon = newPolygon;
            }
        }

        private void ChekAllPoints()
        {
            string pointsPath = txtPointPath.Text;
            string[] allPoints = GetUserData(pointsPath);

            for (int i = 0; i < allPoints.Length; i++)
            {
                if (string.IsNullOrEmpty(allPoints[i]))
                {
                    Console.WriteLine($"Строка №{i} пустая.");
                    break;
                }

                string[] splitCoordinates = allPoints[i].Split(' ');
                string coordX = splitCoordinates[2].Remove(0, deleteChars);
                string coordY = splitCoordinates[3].Remove(0, deleteChars);
                float coordinateX = float.Parse(coordX, CultureInfo.InvariantCulture);
                float coordinateY = float.Parse(coordY, CultureInfo.InvariantCulture);

                PointF point = new PointF(coordinateX, coordinateY);
                bool result = IsPointInPolygon4(polygon, point);
                
                if (result)
                {
                    SaveResult(allPoints[i]);
                }
                

                if (i == allPoints.Length - 1)
                {
                    Console.WriteLine("Все данные обработаны");
                }
            }
        }

        private void SaveResult(string line)
        {
            using (FileStream file = new FileStream(resultPath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(file)) writer.WriteLine(line);
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

        private void btnOpenPoint_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pathRead = new OpenFileDialog())
            {
                if (pathRead.ShowDialog() == DialogResult.OK)
                {
                    txtPointPath.Text = pathRead.FileName;
                }
            }
        }

        private void btnOpenPolygon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pathRead = new OpenFileDialog())
            {
                if (pathRead.ShowDialog() == DialogResult.OK)
                {
                    txtPolygonPath.Text = pathRead.FileName;
                }
            }
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                checkPath.Text = openFileDialog.FileName;
                resultPath = openFileDialog.FileName;
            }           
        }

        private void FormWindow_Load(object sender, EventArgs e)
        {

        }

        private void checkPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
