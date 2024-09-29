namespace ex2b_future_value
{
    partial class FormFutureValueForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMonthlyInvestment = new TextBox();
            textBoxYearlyInterestRate = new TextBox();
            textBoxNumberOfYears = new TextBox();
            textBoxFutureValue = new TextBox();
            buttonCalculate = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(51, 108);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 1;
            label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(51, 172);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 2;
            label3.Text = "Number of Years:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(51, 236);
            label4.Name = "label4";
            label4.Size = new Size(153, 32);
            label4.TabIndex = 3;
            label4.Text = "Future Value:";
            // 
            // textBoxMonthlyInvestment
            // 
            textBoxMonthlyInvestment.Font = new Font("Segoe UI", 12F);
            textBoxMonthlyInvestment.Location = new Point(333, 37);
            textBoxMonthlyInvestment.Name = "textBoxMonthlyInvestment";
            textBoxMonthlyInvestment.Size = new Size(150, 39);
            textBoxMonthlyInvestment.TabIndex = 4;
            // 
            // textBoxYearlyInterestRate
            // 
            textBoxYearlyInterestRate.Font = new Font("Segoe UI", 12F);
            textBoxYearlyInterestRate.Location = new Point(333, 101);
            textBoxYearlyInterestRate.Name = "textBoxYearlyInterestRate";
            textBoxYearlyInterestRate.Size = new Size(150, 39);
            textBoxYearlyInterestRate.TabIndex = 5;
            // 
            // textBoxNumberOfYears
            // 
            textBoxNumberOfYears.Font = new Font("Segoe UI", 12F);
            textBoxNumberOfYears.Location = new Point(333, 165);
            textBoxNumberOfYears.Name = "textBoxNumberOfYears";
            textBoxNumberOfYears.Size = new Size(150, 39);
            textBoxNumberOfYears.TabIndex = 6;
            // 
            // textBoxFutureValue
            // 
            textBoxFutureValue.Font = new Font("Segoe UI", 12F);
            textBoxFutureValue.Location = new Point(333, 229);
            textBoxFutureValue.Name = "textBoxFutureValue";
            textBoxFutureValue.ReadOnly = true;
            textBoxFutureValue.Size = new Size(150, 39);
            textBoxFutureValue.TabIndex = 7;
            textBoxFutureValue.TabStop = false;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 12F);
            buttonCalculate.Location = new Point(229, 319);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(124, 49);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "&Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(359, 319);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(124, 49);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormFutureValueForm
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(534, 413);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxFutureValue);
            Controls.Add(textBoxNumberOfYears);
            Controls.Add(textBoxYearlyInterestRate);
            Controls.Add(textBoxMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFutureValueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMonthlyInvestment;
        private TextBox textBoxYearlyInterestRate;
        private TextBox textBoxNumberOfYears;
        private TextBox textBoxFutureValue;
        private Button buttonCalculate;
        private Button buttonExit;
    }
}
