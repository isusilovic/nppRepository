namespace vjezba_forma
{
    partial class Racunarko
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
            this.btnNewBill = new System.Windows.Forms.Button();
            this.LblHeading = new System.Windows.Forms.Label();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.rbtnIt = new System.Windows.Forms.RadioButton();
            this.rbtnTermalEnergy = new System.Windows.Forms.RadioButton();
            this.rbtnUtilities = new System.Windows.Forms.RadioButton();
            this.rbtnGas = new System.Windows.Forms.RadioButton();
            this.rbtnElectricEnergy = new System.Windows.Forms.RadioButton();
            this.rbtnWater = new System.Windows.Forms.RadioButton();
            this.dgvListBills = new System.Windows.Forms.DataGridView();
            this.lblBillChoice = new System.Windows.Forms.Label();
            this.gbForm.SuspendLayout();
            this.gbChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBills)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewBill
            // 
            this.btnNewBill.Location = new System.Drawing.Point(3, 337);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(160, 33);
            this.btnNewBill.TabIndex = 5;
            this.btnNewBill.Text = "Novi račun";
            this.btnNewBill.UseVisualStyleBackColor = true;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(12, 9);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(171, 39);
            this.LblHeading.TabIndex = 6;
            this.LblHeading.Text = "RAČUNarko";
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.gbChoice);
            this.gbForm.Controls.Add(this.dgvListBills);
            this.gbForm.Controls.Add(this.lblBillChoice);
            this.gbForm.Location = new System.Drawing.Point(12, 51);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(661, 413);
            this.gbForm.TabIndex = 9;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Pregled računa";
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.rbtnIt);
            this.gbChoice.Controls.Add(this.rbtnTermalEnergy);
            this.gbChoice.Controls.Add(this.rbtnUtilities);
            this.gbChoice.Controls.Add(this.btnNewBill);
            this.gbChoice.Controls.Add(this.rbtnGas);
            this.gbChoice.Controls.Add(this.rbtnElectricEnergy);
            this.gbChoice.Controls.Add(this.rbtnWater);
            this.gbChoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChoice.Location = new System.Drawing.Point(488, 15);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(167, 376);
            this.gbChoice.TabIndex = 14;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Unos računa";
            // 
            // rbtnIt
            // 
            this.rbtnIt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIt.Location = new System.Drawing.Point(6, 217);
            this.rbtnIt.Name = "rbtnIt";
            this.rbtnIt.Size = new System.Drawing.Size(157, 24);
            this.rbtnIt.TabIndex = 6;
            this.rbtnIt.TabStop = true;
            this.rbtnIt.Text = "račun za IT : Bnet";
            this.rbtnIt.UseVisualStyleBackColor = true;
            // 
            // rbtnTermalEnergy
            // 
            this.rbtnTermalEnergy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTermalEnergy.Location = new System.Drawing.Point(6, 187);
            this.rbtnTermalEnergy.Name = "rbtnTermalEnergy";
            this.rbtnTermalEnergy.Size = new System.Drawing.Size(157, 24);
            this.rbtnTermalEnergy.TabIndex = 5;
            this.rbtnTermalEnergy.TabStop = true;
            this.rbtnTermalEnergy.Text = "račun za toplinu";
            this.rbtnTermalEnergy.UseVisualStyleBackColor = true;
            // 
            // rbtnUtilities
            // 
            this.rbtnUtilities.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUtilities.Location = new System.Drawing.Point(6, 117);
            this.rbtnUtilities.Name = "rbtnUtilities";
            this.rbtnUtilities.Size = new System.Drawing.Size(157, 34);
            this.rbtnUtilities.TabIndex = 3;
            this.rbtnUtilities.TabStop = true;
            this.rbtnUtilities.Text = "račun za komunalne naknade";
            this.rbtnUtilities.UseVisualStyleBackColor = true;
            // 
            // rbtnGas
            // 
            this.rbtnGas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGas.Location = new System.Drawing.Point(6, 87);
            this.rbtnGas.Name = "rbtnGas";
            this.rbtnGas.Size = new System.Drawing.Size(157, 24);
            this.rbtnGas.TabIndex = 2;
            this.rbtnGas.TabStop = true;
            this.rbtnGas.Text = "račun za plin";
            this.rbtnGas.UseVisualStyleBackColor = true;
            // 
            // rbtnElectricEnergy
            // 
            this.rbtnElectricEnergy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnElectricEnergy.Location = new System.Drawing.Point(6, 57);
            this.rbtnElectricEnergy.Name = "rbtnElectricEnergy";
            this.rbtnElectricEnergy.Size = new System.Drawing.Size(157, 24);
            this.rbtnElectricEnergy.TabIndex = 1;
            this.rbtnElectricEnergy.TabStop = true;
            this.rbtnElectricEnergy.Text = "račun za struju";
            this.rbtnElectricEnergy.UseVisualStyleBackColor = true;
            // 
            // rbtnWater
            // 
            this.rbtnWater.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWater.Location = new System.Drawing.Point(6, 157);
            this.rbtnWater.Name = "rbtnWater";
            this.rbtnWater.Size = new System.Drawing.Size(157, 24);
            this.rbtnWater.TabIndex = 0;
            this.rbtnWater.TabStop = true;
            this.rbtnWater.Text = "račun za vodu";
            this.rbtnWater.UseVisualStyleBackColor = true;
            // 
            // dgvListBills
            // 
            this.dgvListBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBills.Location = new System.Drawing.Point(7, 90);
            this.dgvListBills.Name = "dgvListBills";
            this.dgvListBills.Size = new System.Drawing.Size(469, 301);
            this.dgvListBills.TabIndex = 4;
            // 
            // lblBillChoice
            // 
            this.lblBillChoice.AllowDrop = true;
            this.lblBillChoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillChoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBillChoice.Location = new System.Drawing.Point(9, 26);
            this.lblBillChoice.Margin = new System.Windows.Forms.Padding(3);
            this.lblBillChoice.Name = "lblBillChoice";
            this.lblBillChoice.Padding = new System.Windows.Forms.Padding(5);
            this.lblBillChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBillChoice.Size = new System.Drawing.Size(467, 58);
            this.lblBillChoice.TabIndex = 3;
            this.lblBillChoice.Text = "Odabirom tipa računa prikazati će se lista svih unesenih računa. Nove račune mogu" +
    "će je dodati u izborniku slijeva.\r\n";
            // 
            // Racunarko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 452);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.LblHeading);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Racunarko";
            this.Text = "vjezba";
            this.Load += new System.EventHandler(this.Racunarko_Load);
            this.gbForm.ResumeLayout(false);
            this.gbChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.RadioButton rbtnIt;
        private System.Windows.Forms.RadioButton rbtnTermalEnergy;
        private System.Windows.Forms.RadioButton rbtnUtilities;
        private System.Windows.Forms.RadioButton rbtnGas;
        private System.Windows.Forms.RadioButton rbtnElectricEnergy;
        private System.Windows.Forms.RadioButton rbtnWater;
        private System.Windows.Forms.DataGridView dgvListBills;
        private System.Windows.Forms.Label lblBillChoice;
    }
}

