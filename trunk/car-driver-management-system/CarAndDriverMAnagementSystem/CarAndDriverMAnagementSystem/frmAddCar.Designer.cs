namespace CarAndDriverMAnagementSystem
{
    partial class frmAddCar
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
            this.txtCarcode = new System.Windows.Forms.TextBox();
            this.txtCarname = new System.Windows.Forms.TextBox();
            this.txtSuplier = new System.Windows.Forms.TextBox();
            this.txtCompens = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtRentprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boughtDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Compens Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bought Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "UnitPrice";
            // 
            // txtCarcode
            // 
            this.txtCarcode.Location = new System.Drawing.Point(148, 61);
            this.txtCarcode.Name = "txtCarcode";
            this.txtCarcode.Size = new System.Drawing.Size(199, 20);
            this.txtCarcode.TabIndex = 0;
            // 
            // txtCarname
            // 
            this.txtCarname.Location = new System.Drawing.Point(148, 115);
            this.txtCarname.Name = "txtCarname";
            this.txtCarname.Size = new System.Drawing.Size(199, 20);
            this.txtCarname.TabIndex = 1;
            // 
            // txtSuplier
            // 
            this.txtSuplier.Location = new System.Drawing.Point(148, 162);
            this.txtSuplier.Name = "txtSuplier";
            this.txtSuplier.Size = new System.Drawing.Size(199, 20);
            this.txtSuplier.TabIndex = 2;
            // 
            // txtCompens
            // 
            this.txtCompens.Location = new System.Drawing.Point(148, 205);
            this.txtCompens.Name = "txtCompens";
            this.txtCompens.Size = new System.Drawing.Size(199, 20);
            this.txtCompens.TabIndex = 3;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(147, 304);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(199, 20);
            this.txtUnitprice.TabIndex = 5;
            // 
            // txtRentprice
            // 
            this.txtRentprice.Location = new System.Drawing.Point(147, 349);
            this.txtRentprice.Name = "txtRentprice";
            this.txtRentprice.Size = new System.Drawing.Size(199, 20);
            this.txtRentprice.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "RentPrice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(125, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 37);
            this.label10.TabIndex = 11;
            this.label10.Text = "ADD CAR";
            // 
            // boughtDate
            // 
            this.boughtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boughtDate.Location = new System.Drawing.Point(147, 254);
            this.boughtDate.Name = "boughtDate";
            this.boughtDate.Size = new System.Drawing.Size(200, 20);
            this.boughtDate.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boughtDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRentprice);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtCompens);
            this.Controls.Add(this.txtSuplier);
            this.Controls.Add(this.txtCarname);
            this.Controls.Add(this.txtCarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCar";
     //       this.Load += new System.EventHandler(this.frmAddCar_Load);
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
        private System.Windows.Forms.TextBox txtCarcode;
        private System.Windows.Forms.TextBox txtCarname;
        private System.Windows.Forms.TextBox txtSuplier;
        private System.Windows.Forms.TextBox txtCompens;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtRentprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker boughtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}