
namespace ST10083941_PROG221_POE
{
    partial class Rental
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
            this.lblRenting = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.nudRent = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRental = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRent)).BeginInit();
            this.gbRental.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRenting
            // 
            this.lblRenting.AutoSize = true;
            this.lblRenting.Location = new System.Drawing.Point(98, 37);
            this.lblRenting.Name = "lblRenting";
            this.lblRenting.Size = new System.Drawing.Size(48, 20);
            this.lblRenting.TabIndex = 0;
            this.lblRenting.Text = "Rent";
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
            // nudRent
            // 
            this.nudRent.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRent.Location = new System.Drawing.Point(115, 69);
            this.nudRent.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRent.Name = "nudRent";
            this.nudRent.Size = new System.Drawing.Size(163, 26);
            this.nudRent.TabIndex = 7;
            this.nudRent.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(115, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRental
            // 
            this.gbRental.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbRental.Controls.Add(this.btnSave);
            this.gbRental.Controls.Add(this.nudRent);
            this.gbRental.Controls.Add(this.lblCurrency);
            this.gbRental.Controls.Add(this.lblRenting);
            this.gbRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRental.ForeColor = System.Drawing.Color.White;
            this.gbRental.Location = new System.Drawing.Point(12, 12);
            this.gbRental.Name = "gbRental";
            this.gbRental.Size = new System.Drawing.Size(375, 218);
            this.gbRental.TabIndex = 3;
            this.gbRental.TabStop = false;
            this.gbRental.Text = "Renting";
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(399, 242);
            this.Controls.Add(this.gbRental);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.nudRent)).EndInit();
            this.gbRental.ResumeLayout(false);
            this.gbRental.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRenting;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.NumericUpDown nudRent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRental;
    }
}