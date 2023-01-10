
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
            this.txtPointPath = new System.Windows.Forms.TextBox();
            this.txtPolygonPath = new System.Windows.Forms.TextBox();
            this.btnOpenPoint = new System.Windows.Forms.Button();
            this.btnOpenPolygon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.Location = new System.Drawing.Point(422, 130);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(125, 50);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "ReadFile";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPointPath
            // 
            this.txtPointPath.Location = new System.Drawing.Point(12, 38);
            this.txtPointPath.Name = "txtPointPath";
            this.txtPointPath.Size = new System.Drawing.Size(437, 20);
            this.txtPointPath.TabIndex = 1;
            // 
            // txtPolygonPath
            // 
            this.txtPolygonPath.Location = new System.Drawing.Point(12, 86);
            this.txtPolygonPath.Name = "txtPolygonPath";
            this.txtPolygonPath.Size = new System.Drawing.Size(437, 20);
            this.txtPolygonPath.TabIndex = 2;
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.Location = new System.Drawing.Point(455, 33);
            this.btnOpenPoint.Name = "btnOpenPoint";
            this.btnOpenPoint.Size = new System.Drawing.Size(92, 28);
            this.btnOpenPoint.TabIndex = 3;
            this.btnOpenPoint.Text = "Open Point";
            this.btnOpenPoint.UseVisualStyleBackColor = true;
            this.btnOpenPoint.Click += new System.EventHandler(this.btnOpenPoint_Click);
            // 
            // btnOpenPolygon
            // 
            this.btnOpenPolygon.Location = new System.Drawing.Point(455, 78);
            this.btnOpenPolygon.Name = "btnOpenPolygon";
            this.btnOpenPolygon.Size = new System.Drawing.Size(92, 28);
            this.btnOpenPolygon.TabIndex = 4;
            this.btnOpenPolygon.Text = "Open Polygon";
            this.btnOpenPolygon.UseVisualStyleBackColor = true;
            this.btnOpenPolygon.Click += new System.EventHandler(this.btnOpenPolygon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path to points coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path to polygon coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attention! The coordinates must be in the correct sequence";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenPolygon);
            this.Controls.Add(this.btnOpenPoint);
            this.Controls.Add(this.txtPolygonPath);
            this.Controls.Add(this.txtPointPath);
            this.Controls.Add(this.ReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.TextBox txtPointPath;
        private System.Windows.Forms.TextBox txtPolygonPath;
        private System.Windows.Forms.Button btnOpenPoint;
        private System.Windows.Forms.Button btnOpenPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

