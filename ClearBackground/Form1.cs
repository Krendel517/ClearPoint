using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClearBackground
{
    public partial class FormWindow : Form
    {
        private string resultPath;
        PointD[] polygon = new PointD[4];

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

                    string[] splitCoordinates = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    bool isNumberX = Double.TryParse(splitCoordinates[userIndexOfX - 1], NumberStyles.Float, CultureInfo.InvariantCulture, out double coordinateX);
                    bool isNumberY = Double.TryParse(splitCoordinates[userIndexOfY - 1], NumberStyles.Float, CultureInfo.InvariantCulture, out double coordinateY);

                    if (!isNumberX || !isNumberY)
                    {
                        errorText.Text = "Invalid separator specified, check the entered data";
                        break;
                    }

                    polygon[i].X = coordinateX;
                    polygon[i].Y = coordinateY;
                }
            }
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

                string[] splitCoordinates = allPoints[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                bool isNumberX = Double.TryParse(splitCoordinates[userIndexOfX - 1], NumberStyles.Number, CultureInfo.InvariantCulture, out double coordinateX);
                bool isNumberY = Double.TryParse(splitCoordinates[userIndexOfY - 1], NumberStyles.Number, CultureInfo.InvariantCulture, out double coordinateY);

                if (!isNumberX || !isNumberY)
                {
                    errorText.Text = "Invalid separator specified, check the entered data";
                    break;
                }

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

        private void InitializeProgressBar(string[] allPoints)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = allPoints.Length;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                checkPath.Text = folderBrowserDialog.SelectedPath;
                resultPath = folderBrowserDialog.SelectedPath;
            }

            string fileName = "Result.txt";
            resultPath = Path.Combine(resultPath, fileName);
            var resultfile = File.Create(resultPath);
            resultfile.Close();
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

        private void indexOfX_TextChanged(object sender, EventArgs e)
        {

        }

        private void indexOfY_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
