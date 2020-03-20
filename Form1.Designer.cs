namespace FutureValue19
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnInputRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(63, 314);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(232, 314);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Monthly Investment";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(218, 34);
            this.txtMonthlyInvestment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(148, 26);
            this.txtMonthlyInvestment.TabIndex = 21;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMonthlyInvestment.MouseHover += new System.EventHandler(this.ClearFutureValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yearly Interest Rate";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(218, 105);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(148, 26);
            this.txtInterestRate.TabIndex = 23;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number of Years";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(218, 175);
            this.txtYears.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(148, 26);
            this.txtYears.TabIndex = 25;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Future Value";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(218, 246);
            this.txtFutureValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(148, 26);
            this.txtFutureValue.TabIndex = 27;
            this.txtFutureValue.TabStop = false;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(409, 173);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(125, 31);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "Input &Years";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(409, 32);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(125, 31);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "&Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnInputRate
            // 
            this.btnInputRate.Location = new System.Drawing.Point(409, 103);
            this.btnInputRate.Name = "btnInputRate";
            this.btnInputRate.Size = new System.Drawing.Size(125, 31);
            this.btnInputRate.TabIndex = 2;
            this.btnInputRate.Text = "Input &Rate";
            this.btnInputRate.UseVisualStyleBackColor = true;
            this.btnInputRate.Click += new System.EventHandler(this.btnInputRate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(591, 401);
            this.Controls.Add(this.btnInputRate);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnInputRate;
    }
}

