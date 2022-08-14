namespace CalculatorDemoApp
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
            this.LblFirstNumber = new System.Windows.Forms.Label();
            this.TxtFirstNumber = new System.Windows.Forms.TextBox();
            this.LblSecondNumber = new System.Windows.Forms.Label();
            this.TxtSecondNumber = new System.Windows.Forms.TextBox();
            this.CboOperation = new System.Windows.Forms.ComboBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblFirstNumber
            // 
            this.LblFirstNumber.AutoSize = true;
            this.LblFirstNumber.Location = new System.Drawing.Point(150, 31);
            this.LblFirstNumber.Name = "LblFirstNumber";
            this.LblFirstNumber.Size = new System.Drawing.Size(94, 20);
            this.LblFirstNumber.TabIndex = 0;
            this.LblFirstNumber.Text = "First Number";
            // 
            // TxtFirstNumber
            // 
            this.TxtFirstNumber.Location = new System.Drawing.Point(113, 82);
            this.TxtFirstNumber.Name = "TxtFirstNumber";
            this.TxtFirstNumber.Size = new System.Drawing.Size(125, 27);
            this.TxtFirstNumber.TabIndex = 1;
            // 
            // LblSecondNumber
            // 
            this.LblSecondNumber.AutoSize = true;
            this.LblSecondNumber.Location = new System.Drawing.Point(492, 31);
            this.LblSecondNumber.Name = "LblSecondNumber";
            this.LblSecondNumber.Size = new System.Drawing.Size(116, 20);
            this.LblSecondNumber.TabIndex = 0;
            this.LblSecondNumber.Text = "Second Number";
            // 
            // TxtSecondNumber
            // 
            this.TxtSecondNumber.Location = new System.Drawing.Point(464, 83);
            this.TxtSecondNumber.Name = "TxtSecondNumber";
            this.TxtSecondNumber.Size = new System.Drawing.Size(125, 27);
            this.TxtSecondNumber.TabIndex = 1;
            // 
            // CboOperation
            // 
            this.CboOperation.FormattingEnabled = true;
            this.CboOperation.Location = new System.Drawing.Point(276, 82);
            this.CboOperation.Name = "CboOperation";
            this.CboOperation.Size = new System.Drawing.Size(151, 28);
            this.CboOperation.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(295, 155);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(94, 29);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(328, 232);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(49, 20);
            this.LblResult.TabIndex = 4;
            this.LblResult.Text = "Result";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(286, 255);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(125, 27);
            this.TxtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.CboOperation);
            this.Controls.Add(this.TxtSecondNumber);
            this.Controls.Add(this.TxtFirstNumber);
            this.Controls.Add(this.LblSecondNumber);
            this.Controls.Add(this.LblFirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFirstNumber;
        private TextBox TxtFirstNumber;
        private Label LblSecondNumber;
        private TextBox TxtSecondNumber;
        private ComboBox CboOperation;
        private Button BtnCalculate;
        private Label LblResult;
        private TextBox TxtResult;
    }
}