namespace vjezba_forma
{
    partial class AddSingleReadingBill
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
            this.btnAddSingleReading = new System.Windows.Forms.Button();
            this.lblSingleReading = new System.Windows.Forms.Label();
            this.tbSingleReading = new System.Windows.Forms.TextBox();
            this.dtpSingleReading = new System.Windows.Forms.DateTimePicker();
            this.lblReading = new System.Windows.Forms.Label();
            this.lblDateAddSingleReading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSingleReading
            // 
            this.btnAddSingleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSingleReading.Location = new System.Drawing.Point(17, 151);
            this.btnAddSingleReading.Name = "btnAddSingleReading";
            this.btnAddSingleReading.Size = new System.Drawing.Size(265, 33);
            this.btnAddSingleReading.TabIndex = 0;
            this.btnAddSingleReading.Text = "Unos";
            this.btnAddSingleReading.UseVisualStyleBackColor = true;
            this.btnAddSingleReading.Click += new System.EventHandler(this.btnAddSingleReading_Click);
            // 
            // lblSingleReading
            // 
            this.lblSingleReading.AutoSize = true;
            this.lblSingleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleReading.Location = new System.Drawing.Point(8, 19);
            this.lblSingleReading.Name = "lblSingleReading";
            this.lblSingleReading.Size = new System.Drawing.Size(272, 19);
            this.lblSingleReading.TabIndex = 1;
            this.lblSingleReading.Text = "Unesite stanje mjerila i datum očitanja";
            // 
            // tbSingleReading
            // 
            this.tbSingleReading.Location = new System.Drawing.Point(132, 63);
            this.tbSingleReading.Name = "tbSingleReading";
            this.tbSingleReading.Size = new System.Drawing.Size(150, 20);
            this.tbSingleReading.TabIndex = 2;
            // 
            // dtpSingleReading
            // 
            this.dtpSingleReading.Location = new System.Drawing.Point(132, 107);
            this.dtpSingleReading.Name = "dtpSingleReading";
            this.dtpSingleReading.Size = new System.Drawing.Size(150, 20);
            this.dtpSingleReading.TabIndex = 3;
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReading.Location = new System.Drawing.Point(13, 63);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(98, 19);
            this.lblReading.TabIndex = 4;
            this.lblReading.Text = "Stanje mjerila";
            // 
            // lblDateAddSingleReading
            // 
            this.lblDateAddSingleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAddSingleReading.Location = new System.Drawing.Point(12, 108);
            this.lblDateAddSingleReading.Name = "lblDateAddSingleReading";
            this.lblDateAddSingleReading.Size = new System.Drawing.Size(114, 19);
            this.lblDateAddSingleReading.TabIndex = 5;
            this.lblDateAddSingleReading.Text = "Datum očitanja";
            // 
            // AddSingleReadingBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 198);
            this.Controls.Add(this.lblDateAddSingleReading);
            this.Controls.Add(this.lblReading);
            this.Controls.Add(this.dtpSingleReading);
            this.Controls.Add(this.tbSingleReading);
            this.Controls.Add(this.lblSingleReading);
            this.Controls.Add(this.btnAddSingleReading);
            this.Name = "AddSingleReadingBill";
            this.Text = "AddSingleReadingBill";
            this.Load += new System.EventHandler(this.AddSingleReadingBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSingleReading;
        private System.Windows.Forms.Label lblSingleReading;
        private System.Windows.Forms.TextBox tbSingleReading;
        private System.Windows.Forms.DateTimePicker dtpSingleReading;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.Label lblDateAddSingleReading;
    }
}