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
        Form1 form = new Form1();
        private string saveResult;

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
            form.SaveResult(form.result);
        }

        private void txtDataSave_TextChanged(object sender, EventArgs e)
        {
            saveResult = Convert.ToString(form.resultPath);
            txtDataSave.Text = saveResult;
        }
    }
}
