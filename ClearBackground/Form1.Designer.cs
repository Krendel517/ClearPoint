
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.indexXLbl = new System.Windows.Forms.Label();
            this.indexYbl = new System.Windows.Forms.Label();
            this.separatorLbl = new System.Windows.Forms.Label();
            this.coordinatesStatusLbl = new System.Windows.Forms.Label();
            this.polygonsStatusLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFile.Location = new System.Drawing.Point(430, 430);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(92, 50);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Start";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPointPath
            // 
            this.txtPointPath.Location = new System.Drawing.Point(12, 60);
            this.txtPointPath.Name = "txtPointPath";
            this.txtPointPath.Size = new System.Drawing.Size(400, 20);
            this.txtPointPath.TabIndex = 1;
            // 
            // txtPolygonPath
            // 
            this.txtPolygonPath.Location = new System.Drawing.Point(12, 120);
            this.txtPolygonPath.Name = "txtPolygonPath";
            this.txtPolygonPath.Size = new System.Drawing.Size(400, 20);
            this.txtPolygonPath.TabIndex = 2;
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenPoint.Location = new System.Drawing.Point(430, 55);
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
            this.btnOpenPolygon.Location = new System.Drawing.Point(430, 115);
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
            this.label1.Location = new System.Drawing.Point(12, 40);
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
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attention! The coordinates must be in the correct sequence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add folder for result file";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPath.Location = new System.Drawing.Point(430, 175);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(92, 30);
            this.btnAddPath.TabIndex = 9;
            this.btnAddPath.Text = "Open Folder";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // checkPath
            // 
            this.checkPath.Location = new System.Drawing.Point(12, 180);
            this.checkPath.Name = "checkPath";
            this.checkPath.Size = new System.Drawing.Size(400, 20);
            this.checkPath.TabIndex = 8;
            this.checkPath.TextChanged += new System.EventHandler(this.checkPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path to polygons coordinates";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(430, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // indexOfX
            // 
            this.indexOfX.Location = new System.Drawing.Point(72, 8);
            this.indexOfX.Name = "indexOfX";
            this.indexOfX.Size = new System.Drawing.Size(38, 20);
            this.indexOfX.TabIndex = 12;
            this.indexOfX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipIndexAndSeparator.SetToolTip(this.indexOfX, "Specify the index of X, Y  and separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX=100.000 and has index <3>\r\nY=200.000 and has index <4>\r\nseparator </" +
        "/>");
            this.indexOfX.TextChanged += new System.EventHandler(this.indexOfX_TextChanged);
            // 
            // indexOfY
            // 
            this.indexOfY.Location = new System.Drawing.Point(192, 8);
            this.indexOfY.Name = "indexOfY";
            this.indexOfY.Size = new System.Drawing.Size(38, 20);
            this.indexOfY.TabIndex = 13;
            this.indexOfY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipIndexAndSeparator.SetToolTip(this.indexOfY, "Specify the index of X, Y  and separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX=100.000 and has index <3>\r\nY=200.000 and has index <4>\r\nseparator </" +
        "/>");
            this.indexOfY.TextChanged += new System.EventHandler(this.indexOfY_TextChanged);
            // 
            // userSeparator
            // 
            this.userSeparator.Location = new System.Drawing.Point(325, 8);
            this.userSeparator.Name = "userSeparator";
            this.userSeparator.Size = new System.Drawing.Size(56, 20);
            this.userSeparator.TabIndex = 14;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.toolTipIndexAndSeparator.SetToolTip(this.pictureBox2, "Specify the index of X, Y  and Separator. For example: in line <1//ABC//100.000//" +
        "200.000>\r\nX = 100.000 and has index <3>\r\nY = 200.000 and has index <4>\r\nSeparato" +
        "r <//>\r\n");
            this.pictureBox2.WaitOnLoad = true;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorText.Location = new System.Drawing.Point(12, 220);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(13, 20);
            this.errorText.TabIndex = 15;
            this.errorText.Text = " ";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(12, 265);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 20);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 220);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // indexXLbl
            // 
            this.indexXLbl.AutoSize = true;
            this.indexXLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexXLbl.Location = new System.Drawing.Point(12, 11);
            this.indexXLbl.Name = "indexXLbl";
            this.indexXLbl.Size = new System.Drawing.Size(54, 17);
            this.indexXLbl.TabIndex = 22;
            this.indexXLbl.Text = "X Index";
            // 
            // indexYbl
            // 
            this.indexYbl.AutoSize = true;
            this.indexYbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexYbl.Location = new System.Drawing.Point(132, 11);
            this.indexYbl.Name = "indexYbl";
            this.indexYbl.Size = new System.Drawing.Size(54, 17);
            this.indexYbl.TabIndex = 23;
            this.indexYbl.Text = "Y Index";
            // 
            // separatorLbl
            // 
            this.separatorLbl.AutoSize = true;
            this.separatorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorLbl.Location = new System.Drawing.Point(252, 11);
            this.separatorLbl.Name = "separatorLbl";
            this.separatorLbl.Size = new System.Drawing.Size(71, 17);
            this.separatorLbl.TabIndex = 24;
            this.separatorLbl.Text = "Separator";
            // 
            // coordinatesStatusLbl
            // 
            this.coordinatesStatusLbl.AutoSize = true;
            this.coordinatesStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coordinatesStatusLbl.ForeColor = System.Drawing.Color.Green;
            this.coordinatesStatusLbl.Location = new System.Drawing.Point(12, 80);
            this.coordinatesStatusLbl.Name = "coordinatesStatusLbl";
            this.coordinatesStatusLbl.Size = new System.Drawing.Size(10, 13);
            this.coordinatesStatusLbl.TabIndex = 26;
            this.coordinatesStatusLbl.Text = " ";
            this.coordinatesStatusLbl.Click += new System.EventHandler(this.coordinatesStatusLbl_Click);
            // 
            // polygonsStatusLbl
            // 
            this.polygonsStatusLbl.AutoSize = true;
            this.polygonsStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polygonsStatusLbl.ForeColor = System.Drawing.Color.Green;
            this.polygonsStatusLbl.Location = new System.Drawing.Point(12, 140);
            this.polygonsStatusLbl.Name = "polygonsStatusLbl";
            this.polygonsStatusLbl.Size = new System.Drawing.Size(10, 13);
            this.polygonsStatusLbl.TabIndex = 27;
            this.polygonsStatusLbl.Text = " ";
            this.polygonsStatusLbl.Click += new System.EventHandler(this.polygonsStatusLbl_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.ForeColor = System.Drawing.Color.Green;
            this.resultLbl.Location = new System.Drawing.Point(415, 265);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(12, 17);
            this.resultLbl.TabIndex = 28;
            this.resultLbl.Text = " ";
            this.resultLbl.Click += new System.EventHandler(this.resultLbl_Click);
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 521);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.polygonsStatusLbl);
            this.Controls.Add(this.coordinatesStatusLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.separatorLbl);
            this.Controls.Add(this.indexYbl);
            this.Controls.Add(this.indexXLbl);
            this.Controls.Add(this.pictureBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWindow";
            this.Text = "Clear Point";
            this.Load += new System.EventHandler(this.FormWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label indexXLbl;
        public System.Windows.Forms.Label indexYbl;
        public System.Windows.Forms.Label separatorLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label coordinatesStatusLbl;
        private System.Windows.Forms.Label polygonsStatusLbl;
        private System.Windows.Forms.Label resultLbl;
    }
}

