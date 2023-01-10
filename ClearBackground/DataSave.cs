using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearBackground
{
    public partial class DataSave : Form
    {
        bool saveResult;

        public DataSave()
        {
            InitializeComponent();
        }

        private void SaveHow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDataSave.Text = ofd.FileName;
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.SaveResult(saveResult);
        }

        private void TransitionInSaveWind(bool[] result)
        {
            Form1 form = new Form1();
            form.Hide();
            this.Show();
        }
    }
}
