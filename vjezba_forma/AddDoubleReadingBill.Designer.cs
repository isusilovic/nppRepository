namespace vjezba_forma
{
    partial class AddDoubleReadingBill
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
            this.lblDateAddSingleReading = new System.Windows.Forms.Label();
            this.lblReadingDoubleReadingFirst = new System.Windows.Forms.Label();
            this.dtpDoubleReadingDate = new System.Windows.Forms.DateTimePicker();
            this.tbDoubleReadingFirst = new System.Windows.Forms.TextBox();
            this.lblSingleReading = new System.Windows.Forms.Label();
            this.btnAddDoubleReading = new System.Windows.Forms.Button();
            this.lblReadingDoubleReadingSecond = new System.Windows.Forms.Label();
            this.tbDoubleReadingSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDateAddSingleReading
            // 
            this.lblDateAddSingleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAddSingleReading.Location = new System.Drawing.Point(5, 142);
            this.lblDateAddSingleReading.Name = "lblDateAddSingleReading";
            this.lblDateAddSingleReading.Size = new System.Drawing.Size(114, 19);
            this.lblDateAddSingleReading.TabIndex = 11;
            this.lblDateAddSingleReading.Text = "Datum očitanja";
            // 
            // lblReadingDoubleReadingFirst
            // 
            this.lblReadingDoubleReadingFirst.AutoSize = true;
            this.lblReadingDoubleReadingFirst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadingDoubleReadingFirst.Location = new System.Drawing.Point(5, 67);
            this.lblReadingDoubleReadingFirst.Name = "lblReadingDoubleReadingFirst";
            this.lblReadingDoubleReadingFirst.Size = new System.Drawing.Size(130, 19);
            this.lblReadingDoubleReadingFirst.TabIndex = 10;
            this.lblReadingDoubleReadingFirst.Text = "Prvo stanje mjerila";
            // 
            // dtpDoubleReadingDate
            // 
            this.dtpDoubleReadingDate.Location = new System.Drawing.Point(163, 141);
            this.dtpDoubleReadingDate.Name = "dtpDoubleReadingDate";
            this.dtpDoubleReadingDate.Size = new System.Drawing.Size(150, 20);
            this.dtpDoubleReadingDate.TabIndex = 9;
            // 
            // tbDoubleReadingFirst
            // 
            this.tbDoubleReadingFirst.Location = new System.Drawing.Point(163, 68);
            this.tbDoubleReadingFirst.Name = "tbDoubleReadingFirst";
            this.tbDoubleReadingFirst.Size = new System.Drawing.Size(150, 20);
            this.tbDoubleReadingFirst.TabIndex = 8;
            // 
            // lblSingleReading
            // 
            this.lblSingleReading.AutoSize = true;
            this.lblSingleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleReading.Location = new System.Drawing.Point(5, 24);
            this.lblSingleReading.Name = "lblSingleReading";
            this.lblSingleReading.Size = new System.Drawing.Size(272, 19);
            this.lblSingleReading.TabIndex = 7;
            this.lblSingleReading.Text = "Unesite stanje mjerila i datum očitanja";
            // 
            // btnAddDoubleReading
            // 
            this.btnAddDoubleReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoubleReading.Location = new System.Drawing.Point(9, 179);
            this.btnAddDoubleReading.Name = "btnAddDoubleReading";
            this.btnAddDoubleReading.Size = new System.Drawing.Size(304, 33);
            this.btnAddDoubleReading.TabIndex = 6;
            this.btnAddDoubleReading.Text = "Unos";
            this.btnAddDoubleReading.UseVisualStyleBackColor = true;
            this.btnAddDoubleReading.Click += new System.EventHandler(this.btnAddDoubleReading_Click);
            // 
            // lblReadingDoubleReadingSecond
            // 
            this.lblReadingDoubleReadingSecond.AutoSize = true;
            this.lblReadingDoubleReadingSecond.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadingDoubleReadingSecond.Location = new System.Drawing.Point(5, 106);
            this.lblReadingDoubleReadingSecond.Name = "lblReadingDoubleReadingSecond";
            this.lblReadingDoubleReadingSecond.Size = new System.Drawing.Size(141, 19);
            this.lblReadingDoubleReadingSecond.TabIndex = 13;
            this.lblReadingDoubleReadingSecond.Text = "Drugo stanje mjerila";
            // 
            // tbDoubleReadingSecond
            // 
            this.tbDoubleReadingSecond.Location = new System.Drawing.Point(163, 105);
            this.tbDoubleReadingSecond.Name = "tbDoubleReadingSecond";
            this.tbDoubleReadingSecond.Size = new System.Drawing.Size(150, 20);
            this.tbDoubleReadingSecond.TabIndex = 12;
            // 
            // AddDoubleReadingBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 224);
            this.Controls.Add(this.lblReadingDoubleReadingSecond);
            this.Controls.Add(this.tbDoubleReadingSecond);
            this.Controls.Add(this.lblDateAddSingleReading);
            this.Controls.Add(this.lblReadingDoubleReadingFirst);
            this.Controls.Add(this.dtpDoubleReadingDate);
            this.Controls.Add(this.tbDoubleReadingFirst);
            this.Controls.Add(this.lblSingleReading);
            this.Controls.Add(this.btnAddDoubleReading);
            this.Name = "AddDoubleReadingBill";
            this.Text = "AddDoubleReadingBill";
            this.Load += new System.EventHandler(this.AddMultipleReadingBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateAddSingleReading;
        private System.Windows.Forms.Label lblReadingDoubleReadingFirst;
        private System.Windows.Forms.DateTimePicker dtpDoubleReadingDate;
        private System.Windows.Forms.TextBox tbDoubleReadingFirst;
        private System.Windows.Forms.Label lblSingleReading;
        private System.Windows.Forms.Button btnAddDoubleReading;
        private System.Windows.Forms.Label lblReadingDoubleReadingSecond;
        private System.Windows.Forms.TextBox tbDoubleReadingSecond;
    }
}