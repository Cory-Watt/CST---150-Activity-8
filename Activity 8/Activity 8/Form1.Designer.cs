namespace Activity_8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.carbGrams = new System.Windows.Forms.TextBox();
            this.fatGrams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.calFromCarb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calFromFat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(3, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calculateFatCarb_Click);
            // 
            // carbGrams
            // 
            this.carbGrams.Location = new System.Drawing.Point(150, 47);
            this.carbGrams.Name = "carbGrams";
            this.carbGrams.Size = new System.Drawing.Size(141, 20);
            this.carbGrams.TabIndex = 4;
            // 
            // fatGrams
            // 
            this.fatGrams.Location = new System.Drawing.Point(150, 3);
            this.fatGrams.Name = "fatGrams";
            this.fatGrams.Size = new System.Drawing.Size(141, 20);
            this.fatGrams.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter carbohydrate grams:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter fat grams:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fatGrams, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.carbGrams, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // calFromCarb
            // 
            this.calFromCarb.AutoSize = true;
            this.calFromCarb.Location = new System.Drawing.Point(109, 64);
            this.calFromCarb.Name = "calFromCarb";
            this.calFromCarb.Size = new System.Drawing.Size(0, 13);
            this.calFromCarb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Calories from carbs:";
            // 
            // calFromFat
            // 
            this.calFromFat.AutoSize = true;
            this.calFromFat.Location = new System.Drawing.Point(109, 0);
            this.calFromFat.Name = "calFromFat";
            this.calFromFat.Size = new System.Drawing.Size(0, 13);
            this.calFromFat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calories from fat:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.calFromFat, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.calFromCarb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(328, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 165);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 192);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calories from fat and Carbohydrates";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox carbGrams;
        private System.Windows.Forms.TextBox fatGrams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label calFromCarb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label calFromFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}

