namespace Lesson_Lab8_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtN = new System.Windows.Forms.TextBox();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.TxtMax = new System.Windows.Forms.TextBox();
            this.LblArr = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnNewArr = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtN
            // 
            this.TxtN.Enabled = false;
            this.TxtN.Location = new System.Drawing.Point(209, 32);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 26);
            this.TxtN.TabIndex = 10;
            this.TxtN.Text = "10";
            // 
            // TxtMin
            // 
            this.TxtMin.Location = new System.Drawing.Point(209, 80);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(100, 26);
            this.TxtMin.TabIndex = 1;
            // 
            // TxtMax
            // 
            this.TxtMax.Location = new System.Drawing.Point(209, 133);
            this.TxtMax.Name = "TxtMax";
            this.TxtMax.Size = new System.Drawing.Size(100, 26);
            this.TxtMax.TabIndex = 2;
            // 
            // LblArr
            // 
            this.LblArr.AutoSize = true;
            this.LblArr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblArr.Location = new System.Drawing.Point(40, 22);
            this.LblArr.Name = "LblArr";
            this.LblArr.Size = new System.Drawing.Size(0, 19);
            this.LblArr.TabIndex = 3;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblResult.Location = new System.Drawing.Point(40, 22);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 19);
            this.LblResult.TabIndex = 4;
            // 
            // BtnNewArr
            // 
            this.BtnNewArr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNewArr.Location = new System.Drawing.Point(112, 405);
            this.BtnNewArr.Name = "BtnNewArr";
            this.BtnNewArr.Size = new System.Drawing.Size(139, 33);
            this.BtnNewArr.TabIndex = 5;
            this.BtnNewArr.Text = "Новый массив";
            this.BtnNewArr.UseVisualStyleBackColor = true;
            this.BtnNewArr.Click += new System.EventHandler(this.BtnNewArr_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Enabled = false;
            this.BtnSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSort.Location = new System.Drawing.Point(335, 405);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(139, 33);
            this.BtnSort.TabIndex = 6;
            this.BtnSort.Text = "Сортировка";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(561, 405);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(139, 33);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtN);
            this.groupBox1.Controls.Add(this.TxtMin);
            this.groupBox1.Controls.Add(this.TxtMax);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(36, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры массива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Верхняя граница чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Нижняя граница чисел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во чисел в массиве";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblArr);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(36, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходный массив";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblResult);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox3.Location = new System.Drawing.Point(36, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 50);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Преобразованный массив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnNewArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtN;
        private TextBox TxtMin;
        private TextBox TxtMax;
        private Label LblArr;
        private Label LblResult;
        private Button BtnNewArr;
        private Button BtnSort;
        private Button BtnExit;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}