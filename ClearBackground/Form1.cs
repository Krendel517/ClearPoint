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
        PointF[] polygon = new PointF[4];

        public FormWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPolygon();
            ChekAllPoints();
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
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] splitCoordinates = lines[i].Split(' ');
                    float coordinatesX = float.Parse(CorrectionFormat(splitCoordinates[1]), CultureInfo.InvariantCulture);
                    float coordinatesY = float.Parse(CorrectionFormat(splitCoordinates[2]), CultureInfo.InvariantCulture);
                    polygon[i].X = coordinatesX;
                    polygon[i].Y = coordinatesY;
                }
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
                float coordinateX = float.Parse(CorrectionFormat(splitCoordinates[1]), CultureInfo.InvariantCulture);
                float coordinateY = float.Parse(CorrectionFormat(splitCoordinates[2]), CultureInfo.InvariantCulture);

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
            using (StreamWriter writer = new StreamWriter(file))
                writer.WriteLine(line);
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

        private string CorrectionFormat(string coordiate)
        {
            bool formatIndexIsEmpty = txtCorrectFormat.Text == "";
            int indexForFormatCoordinate;

            if (formatIndexIsEmpty)
                txtCorrectFormat.Text = "0";

            indexForFormatCoordinate = Convert.ToInt32(txtCorrectFormat.Text);
            coordiate = coordiate.Remove(0, indexForFormatCoordinate);
            return coordiate;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}