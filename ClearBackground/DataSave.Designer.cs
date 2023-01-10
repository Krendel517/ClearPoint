
namespace ClearBackground
{
    partial class DataSave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveHow = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.txtDataSave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveHow
            // 
            this.SaveHow.Location = new System.Drawing.Point(493, 12);
            this.SaveHow.Name = "SaveHow";
            this.SaveHow.Size = new System.Drawing.Size(106, 36);
            this.SaveHow.TabIndex = 0;
            this.SaveHow.Text = "Save how...";
            this.SaveHow.UseVisualStyleBackColor = true;
            this.SaveHow.Click += new System.EventHandler(this.SaveHow_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(493, 54);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(106, 44);
            this.SaveFile.TabIndex = 1;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // txtDataSave
            // 
            this.txtDataSave.Location = new System.Drawing.Point(12, 21);
            this.txtDataSave.Name = "txtDataSave";
            this.txtDataSave.Size = new System.Drawing.Size(463, 20);
            this.txtDataSave.TabIndex = 2;
            this.txtDataSave.TextChanged += new System.EventHandler(this.txtDataSave_TextChanged);
            // 
            // DataSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 141);
            this.Controls.Add(this.txtDataSave);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.SaveHow);
            this.Name = "DataSave";
            this.Text = "DataSave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveHow;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.TextBox txtDataSave;
    }
}