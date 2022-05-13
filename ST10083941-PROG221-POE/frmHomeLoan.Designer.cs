
namespace ST10083941_PROG221_POE
{
    partial class frmHomeLoan
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
            this.gbHomeLoan = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudRepayment = new System.Windows.Forms.NumericUpDown();
            this.lblRepayment = new System.Windows.Forms.Label();
            this.nudInterest = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.nudTotalDeposit = new System.Windows.Forms.NumericUpDown();
            this.nudPropertyPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblPropertyPrice = new System.Windows.Forms.Label();
            this.gbHomeLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPropertyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHomeLoan
            // 
            this.gbHomeLoan.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbHomeLoan.Controls.Add(this.btnSave);
            this.gbHomeLoan.Controls.Add(this.nudRepayment);
            this.gbHomeLoan.Controls.Add(this.lblRepayment);
            this.gbHomeLoan.Controls.Add(this.nudInterest);
            this.gbHomeLoan.Controls.Add(this.label2);
            this.gbHomeLoan.Controls.Add(this.lblInterest);
            this.gbHomeLoan.Controls.Add(this.nudTotalDeposit);
            this.gbHomeLoan.Controls.Add(this.nudPropertyPrice);
            this.gbHomeLoan.Controls.Add(this.label1);
            this.gbHomeLoan.Controls.Add(this.lblTotalDeposit);
            this.gbHomeLoan.Controls.Add(this.lblCurrency);
            this.gbHomeLoan.Controls.Add(this.lblPropertyPrice);
            this.gbHomeLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbHomeLoan.ForeColor = System.Drawing.Color.White;
            this.gbHomeLoan.Location = new System.Drawing.Point(12, 12);
            this.gbHomeLoan.Name = "gbHomeLoan";
            this.gbHomeLoan.Size = new System.Drawing.Size(420, 473);
            this.gbHomeLoan.TabIndex = 2;
            this.gbHomeLoan.TabStop = false;
            this.gbHomeLoan.Text = "Home Loan";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(115, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudRepayment
            // 
            this.nudRepayment.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRepayment.Location = new System.Drawing.Point(115, 335);
            this.nudRepayment.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRepayment.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudRepayment.Name = "nudRepayment";
            this.nudRepayment.Size = new System.Drawing.Size(163, 26);
            this.nudRepayment.TabIndex = 14;
            this.nudRepayment.ThousandsSeparator = true;
            this.nudRepayment.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // lblRepayment
            // 
            this.lblRepayment.AutoSize = true;
            this.lblRepayment.Location = new System.Drawing.Point(87, 292);
            this.lblRepayment.Name = "lblRepayment";
            this.lblRepayment.Size = new System.Drawing.Size(233, 20);
            this.lblRepayment.TabIndex = 12;
            this.lblRepayment.Text = "Number of Months to Repay";
            // 
            // nudInterest
            // 
            this.nudInterest.DecimalPlaces = 2;
            this.nudInterest.Location = new System.Drawing.Point(115, 235);
            this.nudInterest.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudInterest.Name = "nudInterest";
            this.nudInterest.Size = new System.Drawing.Size(163, 26);
            this.nudInterest.TabIndex = 11;
            this.nudInterest.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(98, 202);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(148, 20);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "Interest Rate (%)";
            // 
            // nudTotalDeposit
            // 
            this.nudTotalDeposit.DecimalPlaces = 2;
            this.nudTotalDeposit.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalDeposit.Location = new System.Drawing.Point(115, 156);
            this.nudTotalDeposit.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTotalDeposit.Name = "nudTotalDeposit";
            this.nudTotalDeposit.Size = new System.Drawing.Size(163, 26);
            this.nudTotalDeposit.TabIndex = 8;
            this.nudTotalDeposit.ThousandsSeparator = true;
            // 
            // nudPropertyPrice
            // 
            this.nudPropertyPrice.DecimalPlaces = 2;
            this.nudPropertyPrice.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPropertyPrice.Location = new System.Drawing.Point(115, 69);
            this.nudPropertyPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPropertyPrice.Name = "nudPropertyPrice";
            this.nudPropertyPrice.Size = new System.Drawing.Size(163, 26);
            this.nudPropertyPrice.TabIndex = 7;
            this.nudPropertyPrice.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.AutoSize = true;
            this.lblTotalDeposit.Location = new System.Drawing.Point(98, 122);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(116, 20);
            this.lblTotalDeposit.TabIndex = 3;
            this.lblTotalDeposit.Text = "Total Deposit";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(87, 71);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(22, 20);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "R";
            // 
            // lblPropertyPrice
            // 
            this.lblPropertyPrice.AutoSize = true;
            this.lblPropertyPrice.Location = new System.Drawing.Point(98, 37);
            this.lblPropertyPrice.Name = "lblPropertyPrice";
            this.lblPropertyPrice.Size = new System.Drawing.Size(121, 20);
            this.lblPropertyPrice.TabIndex = 0;
            this.lblPropertyPrice.Text = "Property Price";
            // 
            // frmHomeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(444, 497);
            this.Controls.Add(this.gbHomeLoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHomeLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortgage";
            this.gbHomeLoan.ResumeLayout(false);
            this.gbHomeLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPropertyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHomeLoan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudRepayment;
        private System.Windows.Forms.Label lblRepayment;
        private System.Windows.Forms.NumericUpDown nudInterest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.NumericUpDown nudTotalDeposit;
        private System.Windows.Forms.NumericUpDown nudPropertyPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblPropertyPrice;
    }
}