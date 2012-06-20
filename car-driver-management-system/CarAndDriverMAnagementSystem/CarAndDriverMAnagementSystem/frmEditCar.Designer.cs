namespace CarAndDriverMAnagementSystem
{
    partial class frmEditCar
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
            this.add = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarname = new System.Windows.Forms.TextBox();
            this.txtCarcode = new System.Windows.Forms.TextBox();
            this.txtSuplier = new System.Windows.Forms.TextBox();
            this.txtCompensAmout = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpBoughtDate = new System.Windows.Forms.DateTimePicker();
            this.txtLiquidationreason = new System.Windows.Forms.TextBox();
            this.dtpLiquidationDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Red;
            this.add.Location = new System.Drawing.Point(177, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(93, 37);
            this.add.TabIndex = 0;
            this.add.Text = "EDIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Car Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Compens Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bought Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rent Price";
            // 
            // txtCarname
            // 
            this.txtCarname.Location = new System.Drawing.Point(200, 70);
            this.txtCarname.Name = "txtCarname";
            this.txtCarname.Size = new System.Drawing.Size(161, 20);
            this.txtCarname.TabIndex = 1;
            // 
            // txtCarcode
            // 
            this.txtCarcode.Location = new System.Drawing.Point(200, 113);
            this.txtCarcode.Name = "txtCarcode";
            this.txtCarcode.ReadOnly = true;
            this.txtCarcode.Size = new System.Drawing.Size(161, 20);
            this.txtCarcode.TabIndex = 1;
            // 
            // txtSuplier
            // 
            this.txtSuplier.Location = new System.Drawing.Point(200, 153);
            this.txtSuplier.Name = "txtSuplier";
            this.txtSuplier.Size = new System.Drawing.Size(161, 20);
            this.txtSuplier.TabIndex = 1;
            // 
            // txtCompensAmout
            // 
            this.txtCompensAmout.Location = new System.Drawing.Point(200, 199);
            this.txtCompensAmout.Name = "txtCompensAmout";
            this.txtCompensAmout.Size = new System.Drawing.Size(161, 20);
            this.txtCompensAmout.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(200, 299);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(161, 20);
            this.txtUnitPrice.TabIndex = 1;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(200, 347);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(161, 20);
            this.txtRentPrice.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Liquidation Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Liquidation Reason";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpBoughtDate
            // 
            this.dtpBoughtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBoughtDate.Location = new System.Drawing.Point(200, 247);
            this.dtpBoughtDate.Name = "dtpBoughtDate";
            this.dtpBoughtDate.Size = new System.Drawing.Size(161, 20);
            this.dtpBoughtDate.TabIndex = 3;
            // 
            // txtLiquidationreason
            // 
            this.txtLiquidationreason.Location = new System.Drawing.Point(200, 388);
            this.txtLiquidationreason.Name = "txtLiquidationreason";
            this.txtLiquidationreason.Size = new System.Drawing.Size(161, 20);
            this.txtLiquidationreason.TabIndex = 1;
            this.txtLiquidationreason.TextChanged += new System.EventHandler(this.txtLiquidationreason_TextChanged);
            // 
            // dtpLiquidationDate
            // 
            this.dtpLiquidationDate.Enabled = false;
            this.dtpLiquidationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLiquidationDate.Location = new System.Drawing.Point(200, 435);
            this.dtpLiquidationDate.Name = "dtpLiquidationDate";
            this.dtpLiquidationDate.Size = new System.Drawing.Size(161, 20);
            this.dtpLiquidationDate.TabIndex = 4;
            // 
            // frmEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 529);
            this.Controls.Add(this.dtpLiquidationDate);
            this.Controls.Add(this.dtpBoughtDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLiquidationreason);
            this.Controls.Add(this.txtRentPrice);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCompensAmout);
            this.Controls.Add(this.txtSuplier);
            this.Controls.Add(this.txtCarcode);
            this.Controls.Add(this.txtCarname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Name = "frmEditCar";
            this.Text = "frmEditCar";
            this.Load += new System.EventHandler(this.frmEditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarname;
        private System.Windows.Forms.TextBox txtCarcode;
        private System.Windows.Forms.TextBox txtSuplier;
        private System.Windows.Forms.TextBox txtCompensAmout;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpBoughtDate;
        private System.Windows.Forms.TextBox txtLiquidationreason;
        private System.Windows.Forms.DateTimePicker dtpLiquidationDate;
    }
}