﻿
namespace ST10083941_PROG221_POE
{
    partial class frmReport
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
            this.rtbAllExpenses = new System.Windows.Forms.RichTextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAllExpenses
            // 
            this.rtbAllExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbAllExpenses.Location = new System.Drawing.Point(12, 56);
            this.rtbAllExpenses.Name = "rtbAllExpenses";
            this.rtbAllExpenses.ReadOnly = true;
            this.rtbAllExpenses.Size = new System.Drawing.Size(365, 261);
            this.rtbAllExpenses.TabIndex = 0;
            this.rtbAllExpenses.Text = "";
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.SystemColors.Window;
            this.btnDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesc.ForeColor = System.Drawing.Color.Black;
            this.btnDesc.Location = new System.Drawing.Point(12, 24);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(107, 26);
            this.btnDesc.TabIndex = 1;
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.BackColor = System.Drawing.SystemColors.Window;
            this.btnAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsc.ForeColor = System.Drawing.Color.Black;
            this.btnAsc.Location = new System.Drawing.Point(125, 24);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(107, 26);
            this.btnAsc.TabIndex = 2;
            this.btnAsc.UseVisualStyleBackColor = false;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Window;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(214, 341);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(163, 50);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(394, 403);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.rtbAllExpenses);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAllExpenses;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
    }
}