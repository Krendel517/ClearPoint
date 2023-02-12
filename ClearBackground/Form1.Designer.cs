
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindow));
            this.ReadFile = new System.Windows.Forms.Button();
            this.txtPointPath = new System.Windows.Forms.TextBox();
            this.txtPolygonPath = new System.Windows.Forms.TextBox();
            this.btnOpenPoint = new System.Windows.Forms.Button();
            this.btnOpenPolygon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.checkPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.indexOfX = new System.Windows.Forms.TextBox();
            this.indexOfY = new System.Windows.Forms.TextBox();
            this.userSeparator = new System.Windows.Forms.TextBox();
            this.toolTipIndexAndSeparator = new System.Windows.Forms.ToolTip(this.components);
            this.errorText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PPointsOkLbl = new System.Windows.Forms.Label();
            this.CPointsOkLbl = new System.Windows.Forms.Label();
            this.savedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFile.Location = new System.Drawing.Point(455, 195);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(92, 50);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Start";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPointPath
            // 
            this.txtPointPath.Location = new System.Drawing.Point(12, 25);
            this.txtPointPath.Name = "txtPointPath";
            this.txtPointPath.Size = new System.Drawing.Size(437, 20);
            this.txtPointPath.TabIndex = 1;
            // 
            // txtPolygonPath
            // 
            this.txtPolygonPath.Location = new System.Drawing.Point(12, 85);
            this.txtPolygonPath.Name = "txtPolygonPath";
            this.txtPolygonPath.Size = new System.Drawing.Size(437, 20);
            this.txtPolygonPath.TabIndex = 2;
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenPoint.Location = new System.Drawing.Point(455, 20);
            this.btnOpenPoint.Name = "btnOpenPoint";
            this.btnOpenPoint.Size = new System.Drawing.Size(92, 30);
            this.btnOpenPoint.TabIndex = 3;
            this.btnOpenPoint.Text = "Open Point";
            this.btnOpenPoint.UseVisualStyleBackColor = true;
            this.btnOpenPoint.Click += new System.EventHandler(this.btnOpenPoint_Click);
            // 
            // btnOpenPolygon
            // 
            this.btnOpenPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenPolygon.Location = new System.Drawing.Point(455, 80);
            this.btnOpenPolygon.Name = "btnOpenPolygon";
            this.btnOpenPolygon.Size = new System.Drawing.Size(92, 30);
            this.btnOpenPolygon.TabIndex = 4;
            this.btnOpenPolygon.Text = "Open Polygon";
            this.btnOpenPolygon.UseVisualStyleBackColor = true;
            this.btnOpenPolygon.Click += new System.EventHandler(this.btnOpenPolygon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path to points coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attention! The coordinates must be in the correct sequence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add folder for result file";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPath.Location = new System.Drawing.Point(455, 140);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(92, 30);
            this.btnAddPath.TabIndex = 9;
            this.btnAddPath.Text = "Open Folder";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // checkPath
            // 
            this.checkPath.Location = new System.Drawing.Point(12, 145);
            this.checkPath.Name = "checkPath";
            this.checkPath.Size = new System.Drawing.Size(437, 20);
            this.checkPath.TabIndex = 8;
            this.checkPath.TextChanged += new System.EventHandler(this.checkPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path to polygons coordinates";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(455, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // indexOfX
            // 
            this.indexOfX.Location = new System.Drawing.Point(12, 195);
            this.indexOfX.Name = "indexOfX";
            this.indexOfX.Size = new System.Drawing.Size(40, 20);
            this.indexOfX.TabIndex = 12;
            this.indexOfX.Text = "#X";
            this.indexOfX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipIndexAndSeparator.SetToolTip(this.indexOfX, "Specify the index of X, Y  and separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX=100.000 and has index <3>\r\nY=200.000 and has index <4>\r\nseparator </" +
        "/>");
            this.indexOfX.TextChanged += new System.EventHandler(this.indexOfX_TextChanged);
            // 
            // indexOfY
            // 
            this.indexOfY.Location = new System.Drawing.Point(62, 195);
            this.indexOfY.Name = "indexOfY";
            this.indexOfY.Size = new System.Drawing.Size(40, 20);
            this.indexOfY.TabIndex = 13;
            this.indexOfY.Text = "#Y";
            this.indexOfY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipIndexAndSeparator.SetToolTip(this.indexOfY, "Specify the index of X, Y  and separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX=100.000 and has index <3>\r\nY=200.000 and has index <4>\r\nseparator </" +
        "/>");
            this.indexOfY.TextChanged += new System.EventHandler(this.indexOfY_TextChanged);
            // 
            // userSeparator
            // 
            this.userSeparator.Location = new System.Drawing.Point(112, 195);
            this.userSeparator.Name = "userSeparator";
            this.userSeparator.Size = new System.Drawing.Size(55, 20);
            this.userSeparator.TabIndex = 14;
            this.userSeparator.Text = "Separator";
            this.userSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipIndexAndSeparator.SetToolTip(this.userSeparator, "Specify the index of X, Y  and separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX=100.000 and has index <3>\r\nY=200.000 and has index <4>\r\nseparator </" +
        "/>");
            this.userSeparator.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // toolTipIndexAndSeparator
            // 
            this.toolTipIndexAndSeparator.AutomaticDelay = 100;
            this.toolTipIndexAndSeparator.AutoPopDelay = 1000000;
            this.toolTipIndexAndSeparator.InitialDelay = 100;
            this.toolTipIndexAndSeparator.IsBalloon = true;
            this.toolTipIndexAndSeparator.ReshowDelay = 20;
            this.toolTipIndexAndSeparator.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipIndexAndSeparator.ToolTipTitle = "Important information";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorText.Location = new System.Drawing.Point(12, 230);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(13, 20);
            this.errorText.TabIndex = 15;
            this.errorText.Text = " ";
            this.errorText.Click += new System.EventHandler(this.errorText_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(200, 195);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 20);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // PPointsOkLbl
            // 
            this.PPointsOkLbl.AutoSize = true;
            this.PPointsOkLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PPointsOkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PPointsOkLbl.ForeColor = System.Drawing.Color.Green;
            this.PPointsOkLbl.Location = new System.Drawing.Point(12, 105);
            this.PPointsOkLbl.Name = "PPointsOkLbl";
            this.PPointsOkLbl.Size = new System.Drawing.Size(10, 13);
            this.PPointsOkLbl.TabIndex = 21;
            this.PPointsOkLbl.Text = " ";
            this.PPointsOkLbl.Click += new System.EventHandler(this.PPointsOkLbl_Click);
            // 
            // CPointsOkLbl
            // 
            this.CPointsOkLbl.AutoSize = true;
            this.CPointsOkLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CPointsOkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPointsOkLbl.ForeColor = System.Drawing.Color.Green;
            this.CPointsOkLbl.Location = new System.Drawing.Point(12, 45);
            this.CPointsOkLbl.Name = "CPointsOkLbl";
            this.CPointsOkLbl.Size = new System.Drawing.Size(10, 13);
            this.CPointsOkLbl.TabIndex = 22;
            this.CPointsOkLbl.Text = " ";
            this.CPointsOkLbl.Click += new System.EventHandler(this.CPointsOkLbl_Click);
            // 
            // savedLbl
            // 
            this.savedLbl.AutoSize = true;
            this.savedLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedLbl.ForeColor = System.Drawing.Color.Green;
            this.savedLbl.Location = new System.Drawing.Point(200, 215);
            this.savedLbl.Name = "savedLbl";
            this.savedLbl.Size = new System.Drawing.Size(10, 13);
            this.savedLbl.TabIndex = 24;
            this.savedLbl.Text = " ";
            this.savedLbl.Click += new System.EventHandler(this.savedLbl_Click);
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 281);
            this.Controls.Add(this.savedLbl);
            this.Controls.Add(this.CPointsOkLbl);
            this.Controls.Add(this.PPointsOkLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.userSeparator);
            this.Controls.Add(this.indexOfY);
            this.Controls.Add(this.indexOfX);
            this.Controls.Add(this.btnExit);
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
            this.Controls.Add(this.ReadFile);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWindow";
            this.Text = "Clear Point";
            this.Load += new System.EventHandler(this.FormWindow_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.TextBox checkPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox indexOfX;
        private System.Windows.Forms.TextBox indexOfY;
        private System.Windows.Forms.TextBox userSeparator;
        private System.Windows.Forms.ToolTip toolTipIndexAndSeparator;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label PPointsOkLbl;
        private System.Windows.Forms.Label CPointsOkLbl;
        private System.Windows.Forms.Label savedLbl;
    }
}

