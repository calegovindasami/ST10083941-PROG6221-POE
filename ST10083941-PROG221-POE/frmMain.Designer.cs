
namespace ST10083941_PROG221_POE
{
    partial class frmMain
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
            this.gbExpenses = new System.Windows.Forms.GroupBox();
            this.rtbExpenses = new System.Windows.Forms.RichTextBox();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.gbAccommodation = new System.Windows.Forms.GroupBox();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.rtbAccommodation = new System.Windows.Forms.RichTextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.gbIncome = new System.Windows.Forms.GroupBox();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.nudIncome = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbExpenses.SuspendLayout();
            this.gbAccommodation.SuspendLayout();
            this.gbIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncome)).BeginInit();
            this.gbReport.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbExpenses
            // 
            this.gbExpenses.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbExpenses.Controls.Add(this.rtbExpenses);
            this.gbExpenses.Controls.Add(this.btnExpenses);
            this.gbExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbExpenses.ForeColor = System.Drawing.Color.White;
            this.gbExpenses.Location = new System.Drawing.Point(12, 265);
            this.gbExpenses.Name = "gbExpenses";
            this.gbExpenses.Size = new System.Drawing.Size(439, 201);
            this.gbExpenses.TabIndex = 1;
            this.gbExpenses.TabStop = false;
            this.gbExpenses.Text = "Monthly Expenses";
            // 
            // rtbExpenses
            // 
            this.rtbExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbExpenses.Location = new System.Drawing.Point(28, 69);
            this.rtbExpenses.Name = "rtbExpenses";
            this.rtbExpenses.ReadOnly = true;
            this.rtbExpenses.Size = new System.Drawing.Size(330, 117);
            this.rtbExpenses.TabIndex = 1;
            this.rtbExpenses.Text = "";
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.SystemColors.Window;
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpenses.ForeColor = System.Drawing.Color.Black;
            this.btnExpenses.Location = new System.Drawing.Point(28, 35);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(163, 28);
            this.btnExpenses.TabIndex = 0;
            this.btnExpenses.Text = "Input Expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // gbAccommodation
            // 
            this.gbAccommodation.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbAccommodation.Controls.Add(this.btnMortgage);
            this.gbAccommodation.Controls.Add(this.rtbAccommodation);
            this.gbAccommodation.Controls.Add(this.btnRent);
            this.gbAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAccommodation.ForeColor = System.Drawing.Color.White;
            this.gbAccommodation.Location = new System.Drawing.Point(480, 45);
            this.gbAccommodation.Name = "gbAccommodation";
            this.gbAccommodation.Size = new System.Drawing.Size(439, 201);
            this.gbAccommodation.TabIndex = 2;
            this.gbAccommodation.TabStop = false;
            this.gbAccommodation.Text = "Accommodation";
            // 
            // btnMortgage
            // 
            this.btnMortgage.BackColor = System.Drawing.SystemColors.Window;
            this.btnMortgage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMortgage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMortgage.ForeColor = System.Drawing.Color.Black;
            this.btnMortgage.Location = new System.Drawing.Point(195, 34);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(163, 28);
            this.btnMortgage.TabIndex = 2;
            this.btnMortgage.Text = "Home Loan";
            this.btnMortgage.UseVisualStyleBackColor = false;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // rtbAccommodation
            // 
            this.rtbAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbAccommodation.Location = new System.Drawing.Point(28, 69);
            this.rtbAccommodation.Name = "rtbAccommodation";
            this.rtbAccommodation.ReadOnly = true;
            this.rtbAccommodation.Size = new System.Drawing.Size(330, 117);
            this.rtbAccommodation.TabIndex = 1;
            this.rtbAccommodation.Text = "";
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.Window;
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRent.ForeColor = System.Drawing.Color.Black;
            this.btnRent.Location = new System.Drawing.Point(28, 35);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(163, 28);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Renting";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // gbIncome
            // 
            this.gbIncome.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbIncome.Controls.Add(this.nudTax);
            this.gbIncome.Controls.Add(this.nudIncome);
            this.gbIncome.Controls.Add(this.label1);
            this.gbIncome.Controls.Add(this.lblTax);
            this.gbIncome.Controls.Add(this.lblCurrency);
            this.gbIncome.Controls.Add(this.lblIncome);
            this.gbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIncome.ForeColor = System.Drawing.Color.White;
            this.gbIncome.Location = new System.Drawing.Point(12, 45);
            this.gbIncome.Name = "gbIncome";
            this.gbIncome.Size = new System.Drawing.Size(439, 201);
            this.gbIncome.TabIndex = 0;
            this.gbIncome.TabStop = false;
            this.gbIncome.Text = "Monthly Income";
            // 
            // nudTax
            // 
            this.nudTax.DecimalPlaces = 2;
            this.nudTax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTax.Location = new System.Drawing.Point(56, 156);
            this.nudTax.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(163, 26);
            this.nudTax.TabIndex = 8;
            this.nudTax.ThousandsSeparator = true;
            // 
            // nudIncome
            // 
            this.nudIncome.DecimalPlaces = 2;
            this.nudIncome.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIncome.Location = new System.Drawing.Point(56, 69);
            this.nudIncome.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudIncome.Name = "nudIncome";
            this.nudIncome.Size = new System.Drawing.Size(163, 26);
            this.nudIncome.TabIndex = 7;
            this.nudIncome.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(28, 118);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(191, 20);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Monthly Tax Deduction";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(28, 71);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(22, 20);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "R";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(28, 38);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(355, 20);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Gross Monthly Income (Before Deductions)";
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbReport.Controls.Add(this.rtbReport);
            this.gbReport.Controls.Add(this.btnReset);
            this.gbReport.Controls.Add(this.btnCalculate);
            this.gbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbReport.ForeColor = System.Drawing.Color.White;
            this.gbReport.Location = new System.Drawing.Point(480, 265);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(439, 201);
            this.gbReport.TabIndex = 6;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Budget Report";
            // 
            // rtbReport
            // 
            this.rtbReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbReport.Location = new System.Drawing.Point(23, 69);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(398, 117);
            this.rtbReport.TabIndex = 8;
            this.rtbReport.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(192, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(23, 35);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbReport);
            this.gbMain.Controls.Add(this.gbIncome);
            this.gbMain.Controls.Add(this.gbAccommodation);
            this.gbMain.Controls.Add(this.gbExpenses);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMain.ForeColor = System.Drawing.Color.Black;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(937, 482);
            this.gbMain.TabIndex = 7;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Welcome To Your Budget Planning App";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(937, 482);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Planner";
            this.gbExpenses.ResumeLayout(false);
            this.gbAccommodation.ResumeLayout(false);
            this.gbIncome.ResumeLayout(false);
            this.gbIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncome)).EndInit();
            this.gbReport.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExpenses;
        private System.Windows.Forms.RichTextBox rtbExpenses;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.GroupBox gbAccommodation;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.RichTextBox rtbAccommodation;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.GroupBox gbIncome;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.NumericUpDown nudIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbMain;
    }
}

