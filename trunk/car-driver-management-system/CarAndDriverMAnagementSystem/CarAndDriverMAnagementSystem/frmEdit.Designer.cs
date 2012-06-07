namespace CarAndDriverMAnagementSystem
{
    partial class frmEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarcode = new System.Windows.Forms.TextBox();
            this.txtCarname = new System.Windows.Forms.TextBox();
            this.txtSuplier = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtRentprice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLiquidationreason = new System.Windows.Forms.TextBox();
            this.BoughtDate = new System.Windows.Forms.DateTimePicker();
            this.LiquidationDate = new System.Windows.Forms.DateTimePicker();
            this.txtCompens = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Car Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suplier";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bought Date";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Compens Count";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "UnitPrice";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCarcode
            // 
            this.txtCarcode.Location = new System.Drawing.Point(182, 78);
            this.txtCarcode.Name = "txtCarcode";
            this.txtCarcode.Size = new System.Drawing.Size(190, 20);
            this.txtCarcode.TabIndex = 1;
            // 
            // txtCarname
            // 
            this.txtCarname.Location = new System.Drawing.Point(182, 112);
            this.txtCarname.Name = "txtCarname";
            this.txtCarname.Size = new System.Drawing.Size(190, 20);
            this.txtCarname.TabIndex = 1;
            // 
            // txtSuplier
            // 
            this.txtSuplier.Location = new System.Drawing.Point(182, 144);
            this.txtSuplier.Name = "txtSuplier";
            this.txtSuplier.Size = new System.Drawing.Size(190, 20);
            this.txtSuplier.TabIndex = 1;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(182, 253);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(190, 20);
            this.txtUnitprice.TabIndex = 1;
            // 
            // txtRentprice
            // 
            this.txtRentprice.Location = new System.Drawing.Point(182, 291);
            this.txtRentprice.Name = "txtRentprice";
            this.txtRentprice.Size = new System.Drawing.Size(190, 20);
            this.txtRentprice.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "RentPrice";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Liquidation Date";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Liquidation Reason";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLiquidationreason
            // 
            this.txtLiquidationreason.Location = new System.Drawing.Point(182, 359);
            this.txtLiquidationreason.Name = "txtLiquidationreason";
            this.txtLiquidationreason.Size = new System.Drawing.Size(190, 20);
            this.txtLiquidationreason.TabIndex = 1;
            // 
            // BoughtDate
            // 
            this.BoughtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BoughtDate.Location = new System.Drawing.Point(182, 208);
            this.BoughtDate.Name = "BoughtDate";
            this.BoughtDate.Size = new System.Drawing.Size(100, 20);
            this.BoughtDate.TabIndex = 3;
            // 
            // LiquidationDate
            // 
            this.LiquidationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LiquidationDate.Location = new System.Drawing.Point(182, 320);
            this.LiquidationDate.Name = "LiquidationDate";
            this.LiquidationDate.Size = new System.Drawing.Size(100, 20);
            this.LiquidationDate.TabIndex = 4;
            // 
            // txtCompens
            // 
            this.txtCompens.Location = new System.Drawing.Point(182, 176);
            this.txtCompens.Name = "txtCompens";
            this.txtCompens.Size = new System.Drawing.Size(190, 20);
            this.txtCompens.TabIndex = 1;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 462);
            this.Controls.Add(this.LiquidationDate);
            this.Controls.Add(this.BoughtDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLiquidationreason);
            this.Controls.Add(this.txtRentprice);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtCompens);
            this.Controls.Add(this.txtSuplier);
            this.Controls.Add(this.txtCarname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCarcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarcode;
        private System.Windows.Forms.TextBox txtCarname;
        private System.Windows.Forms.TextBox txtSuplier;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtRentprice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLiquidationreason;
        private System.Windows.Forms.DateTimePicker BoughtDate;
        private System.Windows.Forms.DateTimePicker LiquidationDate;
        private System.Windows.Forms.TextBox txtCompens;
    }
}