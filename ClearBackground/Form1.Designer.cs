
namespace ClearBackground
{
    partial class FormWindow
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
            this.txtDeleteChars = new System.Windows.Forms.TextBox();
            this.btnOpenPoint = new System.Windows.Forms.Button();
            this.btnOpenPolygon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.checkPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.Location = new System.Drawing.Point(422, 179);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(125, 50);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Start";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPointPath
            // 
            this.txtPointPath.Location = new System.Drawing.Point(12, 23);
            this.txtPointPath.Name = "txtPointPath";
            this.txtPointPath.Size = new System.Drawing.Size(437, 20);
            this.txtPointPath.TabIndex = 1;
            // 
            // txtPointPath
            // 
            this.txtDeleteChars.Location = new System.Drawing.Point(12, 200);
            this.txtDeleteChars.Name = "txtDeleteChars";
            this.txtDeleteChars.Size = new System.Drawing.Size(40, 20);
            this.txtDeleteChars.TabIndex = 12;
            // 
            // txtPolygonPath
            // 
            this.txtPolygonPath.Location = new System.Drawing.Point(12, 71);
            this.txtPolygonPath.Name = "txtPolygonPath";
            this.txtPolygonPath.Size = new System.Drawing.Size(437, 20);
            this.txtPolygonPath.TabIndex = 2;
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.Location = new System.Drawing.Point(455, 18);
            this.btnOpenPoint.Name = "btnOpenPoint";
            this.btnOpenPoint.Size = new System.Drawing.Size(92, 28);
            this.btnOpenPoint.TabIndex = 3;
            this.btnOpenPoint.Text = "Open Point";
            this.btnOpenPoint.UseVisualStyleBackColor = true;
            this.btnOpenPoint.Click += new System.EventHandler(this.btnOpenPoint_Click);
            // 
            // btnOpenPolygon
            // 
            this.btnOpenPolygon.Location = new System.Drawing.Point(455, 66);
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
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path to points coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attention! The coordinates must be in the correct sequence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add path for result file";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(455, 114);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(92, 28);
            this.btnAddPath.TabIndex = 9;
            this.btnAddPath.Text = "Open Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // checkPath
            // 
            this.checkPath.Location = new System.Drawing.Point(12, 119);
            this.checkPath.Name = "checkPath";
            this.checkPath.Size = new System.Drawing.Size(437, 20);
            this.checkPath.TabIndex = 8;
            this.checkPath.TextChanged += new System.EventHandler(this.checkPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path to polygons coordinates";
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.checkPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenPolygon);
            this.Controls.Add(this.btnOpenPoint);
            this.Controls.Add(this.txtPolygonPath);
            this.Controls.Add(this.txtPointPath);
            this.Controls.Add(this.txtDeleteChars);
            this.Controls.Add(this.ReadFile);
            this.Name = "FormWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.TextBox txtPointPath;
        private System.Windows.Forms.TextBox txtDeleteChars;
        private System.Windows.Forms.TextBox txtPolygonPath;
        private System.Windows.Forms.Button btnOpenPoint;
        private System.Windows.Forms.Button btnOpenPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.TextBox checkPath;
        private System.Windows.Forms.Label label2;
    }
}

