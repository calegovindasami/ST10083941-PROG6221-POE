
namespace ST10083941_PROG221_POE
{
    partial class frmVehicle
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
            this.gbVehicle = new System.Windows.Forms.GroupBox();
            this.tbModelMake = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudInterest = new System.Windows.Forms.NumericUpDown();
            this.nudInsurance = new System.Windows.Forms.NumericUpDown();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.nudTotalDeposit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblModelMake = new System.Windows.Forms.Label();
            this.gbVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVehicle
            // 
            this.gbVehicle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbVehicle.Controls.Add(this.tbModelMake);
            this.gbVehicle.Controls.Add(this.label3);
            this.gbVehicle.Controls.Add(this.nudInterest);
            this.gbVehicle.Controls.Add(this.nudInsurance);
            this.gbVehicle.Controls.Add(this.lblInsurance);
            this.gbVehicle.Controls.Add(this.btnSave);
            this.gbVehicle.Controls.Add(this.lblInterestRate);
            this.gbVehicle.Controls.Add(this.nudTotalDeposit);
            this.gbVehicle.Controls.Add(this.label2);
            this.gbVehicle.Controls.Add(this.lblTotalDeposit);
            this.gbVehicle.Controls.Add(this.nudPurchasePrice);
            this.gbVehicle.Controls.Add(this.label1);
            this.gbVehicle.Controls.Add(this.lblPurchasePrice);
            this.gbVehicle.Controls.Add(this.lblModelMake);
            this.gbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbVehicle.ForeColor = System.Drawing.Color.White;
            this.gbVehicle.Location = new System.Drawing.Point(12, 12);
            this.gbVehicle.Name = "gbVehicle";
            this.gbVehicle.Size = new System.Drawing.Size(420, 543);
            this.gbVehicle.TabIndex = 3;
            this.gbVehicle.TabStop = false;
            this.gbVehicle.Text = "Vehicle";
            // 
            // tbModelMake
            // 
            this.tbModelMake.Location = new System.Drawing.Point(115, 69);
            this.tbModelMake.Name = "tbModelMake";
            this.tbModelMake.Size = new System.Drawing.Size(232, 26);
            this.tbModelMake.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "R";
            // 
            // nudInterest
            // 
            this.nudInterest.DecimalPlaces = 2;
            this.nudInterest.Location = new System.Drawing.Point(115, 329);
            this.nudInterest.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudInterest.Name = "nudInterest";
            this.nudInterest.Size = new System.Drawing.Size(163, 26);
            this.nudInterest.TabIndex = 21;
            this.nudInterest.ThousandsSeparator = true;
            // 
            // nudInsurance
            // 
            this.nudInsurance.DecimalPlaces = 2;
            this.nudInsurance.Location = new System.Drawing.Point(115, 415);
            this.nudInsurance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudInsurance.Name = "nudInsurance";
            this.nudInsurance.Size = new System.Drawing.Size(163, 26);
            this.nudInsurance.TabIndex = 20;
            this.nudInsurance.ThousandsSeparator = true;
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(98, 379);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(249, 20);
            this.lblInsurance.TabIndex = 19;
            this.lblInsurance.Text = "Estimated Insurance Premium";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(115, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(98, 293);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(148, 20);
            this.lblInterestRate.TabIndex = 12;
            this.lblInterestRate.Text = "Interest Rate (%)";
            // 
            // nudTotalDeposit
            // 
            this.nudTotalDeposit.DecimalPlaces = 2;
            this.nudTotalDeposit.Location = new System.Drawing.Point(115, 235);
            this.nudTotalDeposit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTotalDeposit.Name = "nudTotalDeposit";
            this.nudTotalDeposit.Size = new System.Drawing.Size(163, 26);
            this.nudTotalDeposit.TabIndex = 11;
            this.nudTotalDeposit.ThousandsSeparator = true;
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
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.Location = new System.Drawing.Point(98, 202);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(148, 20);
            this.lblTotalDeposit.TabIndex = 9;
            this.lblTotalDeposit.Text = "Total Deposit";
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.DecimalPlaces = 2;
            this.nudPurchasePrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPurchasePrice.Location = new System.Drawing.Point(115, 156);
            this.nudPurchasePrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(163, 26);
            this.nudPurchasePrice.TabIndex = 8;
            this.nudPurchasePrice.ThousandsSeparator = true;
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
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(98, 122);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(129, 20);
            this.lblPurchasePrice.TabIndex = 3;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblModelMake
            // 
            this.lblModelMake.AutoSize = true;
            this.lblModelMake.Location = new System.Drawing.Point(98, 36);
            this.lblModelMake.Name = "lblModelMake";
            this.lblModelMake.Size = new System.Drawing.Size(140, 20);
            this.lblModelMake.TabIndex = 0;
            this.lblModelMake.Text = "Model and Make";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(444, 567);
            this.Controls.Add(this.gbVehicle);
            this.Name = "frmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVehicle";
            this.gbVehicle.ResumeLayout(false);
            this.gbVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVehicle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.NumericUpDown nudTotalDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblModelMake;
        private System.Windows.Forms.NumericUpDown nudInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudInterest;
        private System.Windows.Forms.TextBox tbModelMake;
    }
}