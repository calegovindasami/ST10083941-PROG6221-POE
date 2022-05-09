
namespace ST10083941_PROG221_POE
{
    partial class frmExpenses
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
            this.gbExpenses = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudOther = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.nudPhoneBill = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhoneBill = new System.Windows.Forms.Label();
            this.nudTravel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.nudUtilities = new System.Windows.Forms.NumericUpDown();
            this.nudGroceries = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUtilities = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblGroceries = new System.Windows.Forms.Label();
            this.gbExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUtilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroceries)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExpenses
            // 
            this.gbExpenses.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbExpenses.Controls.Add(this.btnSave);
            this.gbExpenses.Controls.Add(this.nudOther);
            this.gbExpenses.Controls.Add(this.label4);
            this.gbExpenses.Controls.Add(this.lblOther);
            this.gbExpenses.Controls.Add(this.nudPhoneBill);
            this.gbExpenses.Controls.Add(this.label3);
            this.gbExpenses.Controls.Add(this.lblPhoneBill);
            this.gbExpenses.Controls.Add(this.nudTravel);
            this.gbExpenses.Controls.Add(this.label2);
            this.gbExpenses.Controls.Add(this.lblTravel);
            this.gbExpenses.Controls.Add(this.nudUtilities);
            this.gbExpenses.Controls.Add(this.nudGroceries);
            this.gbExpenses.Controls.Add(this.label1);
            this.gbExpenses.Controls.Add(this.lblUtilities);
            this.gbExpenses.Controls.Add(this.lblCurrency);
            this.gbExpenses.Controls.Add(this.lblGroceries);
            this.gbExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbExpenses.ForeColor = System.Drawing.Color.White;
            this.gbExpenses.Location = new System.Drawing.Point(12, 12);
            this.gbExpenses.Name = "gbExpenses";
            this.gbExpenses.Size = new System.Drawing.Size(406, 531);
            this.gbExpenses.TabIndex = 1;
            this.gbExpenses.TabStop = false;
            this.gbExpenses.Text = "Monthly Expenses";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(115, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudOther
            // 
            this.nudOther.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudOther.Location = new System.Drawing.Point(115, 418);
            this.nudOther.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudOther.Name = "nudOther";
            this.nudOther.Size = new System.Drawing.Size(163, 26);
            this.nudOther.TabIndex = 17;
            this.nudOther.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "R";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(98, 386);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(137, 20);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "Other Expenses";
            // 
            // nudPhoneBill
            // 
            this.nudPhoneBill.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPhoneBill.Location = new System.Drawing.Point(115, 335);
            this.nudPhoneBill.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPhoneBill.Name = "nudPhoneBill";
            this.nudPhoneBill.Size = new System.Drawing.Size(163, 26);
            this.nudPhoneBill.TabIndex = 14;
            this.nudPhoneBill.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "R";
            // 
            // lblPhoneBill
            // 
            this.lblPhoneBill.AutoSize = true;
            this.lblPhoneBill.Location = new System.Drawing.Point(87, 292);
            this.lblPhoneBill.Name = "lblPhoneBill";
            this.lblPhoneBill.Size = new System.Drawing.Size(219, 20);
            this.lblPhoneBill.TabIndex = 12;
            this.lblPhoneBill.Text = "Cell Phone and Telephone";
            // 
            // nudTravel
            // 
            this.nudTravel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTravel.Location = new System.Drawing.Point(115, 235);
            this.nudTravel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTravel.Name = "nudTravel";
            this.nudTravel.Size = new System.Drawing.Size(163, 26);
            this.nudTravel.TabIndex = 11;
            this.nudTravel.ThousandsSeparator = true;
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
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Location = new System.Drawing.Point(98, 203);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(57, 20);
            this.lblTravel.TabIndex = 9;
            this.lblTravel.Text = "Travel";
            // 
            // nudUtilities
            // 
            this.nudUtilities.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudUtilities.Location = new System.Drawing.Point(115, 156);
            this.nudUtilities.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudUtilities.Name = "nudUtilities";
            this.nudUtilities.Size = new System.Drawing.Size(163, 26);
            this.nudUtilities.TabIndex = 8;
            this.nudUtilities.ThousandsSeparator = true;
            // 
            // nudGroceries
            // 
            this.nudGroceries.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudGroceries.Location = new System.Drawing.Point(115, 69);
            this.nudGroceries.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudGroceries.Name = "nudGroceries";
            this.nudGroceries.Size = new System.Drawing.Size(163, 26);
            this.nudGroceries.TabIndex = 7;
            this.nudGroceries.ThousandsSeparator = true;
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
            // lblUtilities
            // 
            this.lblUtilities.AutoSize = true;
            this.lblUtilities.Location = new System.Drawing.Point(98, 122);
            this.lblUtilities.Name = "lblUtilities";
            this.lblUtilities.Size = new System.Drawing.Size(146, 20);
            this.lblUtilities.TabIndex = 3;
            this.lblUtilities.Text = "Water and Lights";
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
            // lblGroceries
            // 
            this.lblGroceries.AutoSize = true;
            this.lblGroceries.Location = new System.Drawing.Point(98, 37);
            this.lblGroceries.Name = "lblGroceries";
            this.lblGroceries.Size = new System.Drawing.Size(87, 20);
            this.lblGroceries.TabIndex = 0;
            this.lblGroceries.Text = "Groceries";
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(432, 555);
            this.Controls.Add(this.gbExpenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.gbExpenses.ResumeLayout(false);
            this.gbExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUtilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroceries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExpenses;
        private System.Windows.Forms.NumericUpDown nudOther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.NumericUpDown nudPhoneBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhoneBill;
        private System.Windows.Forms.NumericUpDown nudTravel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.NumericUpDown nudUtilities;
        private System.Windows.Forms.NumericUpDown nudGroceries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUtilities;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblGroceries;
        private System.Windows.Forms.Button btnSave;
    }
}