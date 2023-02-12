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
        PointD[] polygon;

        public FormWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPolygon();
            CheсkAllPoints();
        }

        private string[] GetUserData(string path)
        {
            string[] allLines;
            allLines = File.ReadAllLines(path);
            return allLines;
        }

        private void SetPolygon()
        {
            int userIndexOfX = Int32.Parse(indexOfX.Text);
            int userIndexOfY = Int32.Parse(indexOfY.Text);
            string[] separator = { userSeparator.Text };

            string polygonPath = txtPolygonPath.Text;
            string[] lines = GetUserData(polygonPath);
            polygon = new PointD[lines.Length];

            if (lines.Length < 3)
            {
                Console.WriteLine("Введите минимум 3 точки полигона.");
            }
            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!lines[i].Contains(separator[0]))
                    {
                        errorText.Text = $"Separator not found in line №{i + 1} of polygon coordinates,\ncorrect or specify the correct separator";
                        break;
                    }

                    string[] splitCoordinates = lines[i].Split(separator, StringSplitOptions.None);
                    double coordinatesX = double.Parse(splitCoordinates[userIndexOfX - 1], CultureInfo.InvariantCulture);
                    double coordinatesY = double.Parse(splitCoordinates[userIndexOfY - 1], CultureInfo.InvariantCulture);
                    polygon[i].X = coordinatesX;
                    polygon[i].Y = coordinatesY;
                }

                PolygonDisplay polygonDisplay = new PolygonDisplay();
                polygonDisplay.ScalingPolygon(polygon);
                Draw(polygonDisplay.PolygonPoints);
            }
        }

        private void Draw(PointF[] polygonAfterScale)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.White, 1);
            Brush brush = new SolidBrush(Color.White);
            graphics.Clear(Color.DimGray);
            graphics.DrawPolygon(pen, polygonAfterScale);
            graphics.FillPolygon(brush, polygonAfterScale);
        }

        private void CheсkAllPoints()
        {
            int userIndexOfX = Int32.Parse(indexOfX.Text);
            int userIndexOfY = Int32.Parse(indexOfY.Text);
            string[] separator = { userSeparator.Text };

            string pointsPath = txtPointPath.Text;
            string[] allPoints = GetUserData(pointsPath);

            InitializeProgressBar(allPoints);

            for (int i = 0; i < allPoints.Length; i++)
            {
                if (string.IsNullOrEmpty(allPoints[i]))
                {
                    Console.WriteLine($"Строка №{i} пустая.");
                    break;
                }

                if (!allPoints[i].Contains(separator[0]))
                {
                    errorText.Text = $"Separator not found in line №{i + 1} of points coordinates,\ncorrect or specify the correct separator";
                    break;
                }

                string[] splitCoordinates = allPoints[i].Split(separator, StringSplitOptions.None);
                double coordinateX = double.Parse(splitCoordinates[userIndexOfX - 1], CultureInfo.InvariantCulture);
                double coordinateY = double.Parse(splitCoordinates[userIndexOfY - 1], CultureInfo.InvariantCulture);

                PointD point = new PointD(coordinateX, coordinateY);
                bool result = IsPointInPolygon4(polygon, point);

                if (result)
                {
                    SaveResult(allPoints[i]);
                }

                if (i == allPoints.Length - 1)
                {
                    Console.WriteLine("Все данные обработаны");
                }

                progressBar1.PerformStep();
            }
        }

        private void InitializeProgressBar(string[] allPoints)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = allPoints.Length;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
        }

        private void SaveResult(string line)
        {
            using (FileStream file = new FileStream(resultPath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(file))
                writer.WriteLine(line);
        }

        private bool IsPointInPolygon4(PointD[] currentPolygon, PointD currentPoint)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
