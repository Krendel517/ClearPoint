using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClearBackground
{
    public partial class FormWindow : Form
    {
        private string resultPath;
        PointD[] polygon = new PointD[4];
        PointF[] polygonAfterScale = new PointF[4];
        
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

                    int simpleX = Convert.ToInt32(polygon[i].X);
                    int simpleY = Convert.ToInt32(polygon[i].Y);
                    polygonAfterScale[i].X = simpleX;
                    polygonAfterScale[i].Y = simpleY;
                }

                DrawPolygon();
            }
        }

        private void DrawPolygon()
        {
            bool needToScaleX = false;
            bool needToScaleY = false;
            float[] scaleCoefficientX = new float[polygonAfterScale.Length];
            float[] scaleCoefficientY = new float[polygonAfterScale.Length];
            //max x=400 max y=220

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                if (polygonAfterScale[i].X > 400)
                {
                    needToScaleX = true;
                    break;
                }
            }

            if (needToScaleX)
            {
                for(int i = 0; i < polygonAfterScale.Length; i++)
                {
                    scaleCoefficientX[i] = polygonAfterScale[i].X / 400;
                }

                float maxScaleX = scaleCoefficientX.Max();

                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    polygonAfterScale[i].X = polygonAfterScale[i].X / maxScaleX;
                    polygonAfterScale[i].Y = polygonAfterScale[i].Y / maxScaleX;
                }
            }

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                if (polygonAfterScale[i].Y > 220)
                {
                    needToScaleY = true;
                    break;
                }
            }

            if (needToScaleY)
            {
                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    scaleCoefficientY[i] = polygonAfterScale[i].Y / 220;
                }

                float maxScaleY = scaleCoefficientY.Max();

                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    polygonAfterScale[i].X = polygonAfterScale[i].X / maxScaleY;
                    polygonAfterScale[i].Y = polygonAfterScale[i].Y / maxScaleY;
                }
            }

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                polygonAfterScale[i].X = polygonAfterScale[i].X;
                polygonAfterScale[i].Y = 220 - polygonAfterScale[i].Y;
            }

            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1);
            graphics.DrawPolygon(pen, polygonAfterScale);
        }

        private void CheсkAllPoints()
        {
            int userIndexOfX = Int32.Parse(indexOfX.Text);
            int userIndexOfY = Int32.Parse(indexOfY.Text);
            string[] separator = { userSeparator.Text };

            string pointsPath = txtPointPath.Text;
            string[] allPoints = GetUserData(pointsPath);

            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = allPoints.Length;
            progressBar1.Value = 1;
            progressBar1.Step = 1;

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
