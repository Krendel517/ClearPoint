
namespace ClearBackground
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFile = new System.Windows.Forms.Button();
            this.btnOpenPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathPoint = new System.Windows.Forms.TextBox();
            this.txtPathPolygon = new System.Windows.Forms.TextBox();
            this.btnOpenPolygon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.Location = new System.Drawing.Point(564, 102);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(125, 50);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "ReadFile";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.Location = new System.Drawing.Point(564, 12);
            this.btnOpenPoint.Name = "btnOpenPoint";
            this.btnOpenPoint.Size = new System.Drawing.Size(125, 29);
            this.btnOpenPoint.TabIndex = 3;
            this.btnOpenPoint.Text = "Point";
            this.btnOpenPoint.UseVisualStyleBackColor = true;
            this.btnOpenPoint.Click += new System.EventHandler(this.btnOpenPoint_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path >>";
            // 
            // txtPathPoint
            // 
            this.txtPathPoint.Location = new System.Drawing.Point(65, 12);
            this.txtPathPoint.Name = "txtPathPoint";
            this.txtPathPoint.Size = new System.Drawing.Size(493, 20);
            this.txtPathPoint.TabIndex = 5;
            // 
            // txtPathPolygon
            // 
            this.txtPathPolygon.Location = new System.Drawing.Point(65, 54);
            this.txtPathPolygon.Name = "txtPathPolygon";
            this.txtPathPolygon.Size = new System.Drawing.Size(493, 20);
            this.txtPathPolygon.TabIndex = 6;
            // 
            // btnOpenPolygon
            // 
            this.btnOpenPolygon.Location = new System.Drawing.Point(564, 54);
            this.btnOpenPolygon.Name = "btnOpenPolygon";
            this.btnOpenPolygon.Size = new System.Drawing.Size(125, 28);
            this.btnOpenPolygon.TabIndex = 7;
            this.btnOpenPolygon.Text = "Polygon";
            this.btnOpenPolygon.UseVisualStyleBackColor = true;
            this.btnOpenPolygon.Click += new System.EventHandler(this.btnOpenPolygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 203);
            this.Controls.Add(this.btnOpenPolygon);
            this.Controls.Add(this.txtPathPolygon);
            this.Controls.Add(this.txtPathPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenPoint);
            this.Controls.Add(this.ReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button btnOpenPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathPoint;
        private System.Windows.Forms.TextBox txtPathPolygon;
        private System.Windows.Forms.Button btnOpenPolygon;
    }
}

