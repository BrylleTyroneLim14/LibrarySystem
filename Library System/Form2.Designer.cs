namespace Library_System
{
    partial class frmMain
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
            this.lblYrsOfService = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.txtYrsOfService = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.txtBasicPay = new System.Windows.Forms.TextBox();
            this.lblBasicPay = new System.Windows.Forms.Label();
            this.lblCommision = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonus Computation";
            // 
            // lblYrsOfService
            // 
            this.lblYrsOfService.AutoSize = true;
            this.lblYrsOfService.Location = new System.Drawing.Point(142, 154);
            this.lblYrsOfService.Name = "lblYrsOfService";
            this.lblYrsOfService.Size = new System.Drawing.Size(111, 17);
            this.lblYrsOfService.TabIndex = 1;
            this.lblYrsOfService.Text = "Years in Service";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(167, 186);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(79, 17);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // txtYrsOfService
            // 
            this.txtYrsOfService.Location = new System.Drawing.Point(255, 153);
            this.txtYrsOfService.Name = "txtYrsOfService";
            this.txtYrsOfService.Size = new System.Drawing.Size(100, 22);
            this.txtYrsOfService.TabIndex = 3;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(256, 186);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(100, 22);
            this.txtTotalSales.TabIndex = 4;
            // 
            // txtBasicPay
            // 
            this.txtBasicPay.Location = new System.Drawing.Point(257, 221);
            this.txtBasicPay.Name = "txtBasicPay";
            this.txtBasicPay.Size = new System.Drawing.Size(100, 22);
            this.txtBasicPay.TabIndex = 8;
            // 
            // lblBasicPay
            // 
            this.lblBasicPay.AutoSize = true;
            this.lblBasicPay.Location = new System.Drawing.Point(175, 221);
            this.lblBasicPay.Name = "lblBasicPay";
            this.lblBasicPay.Size = new System.Drawing.Size(70, 17);
            this.lblBasicPay.TabIndex = 6;
            this.lblBasicPay.Text = "Basic Pay";
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Location = new System.Drawing.Point(168, 259);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(76, 17);
            this.lblCommision.TabIndex = 5;
            this.lblCommision.Text = "Commision";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(186, 287);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(58, 17);
            this.lblNetPay.TabIndex = 9;
            this.lblNetPay.Text = "Net Pay";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(255, 334);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(116, 46);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(258, 286);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(100, 22);
            this.txtNetPay.TabIndex = 10;
            // 
            // txtCommision
            // 
            this.txtCommision.Location = new System.Drawing.Point(257, 254);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.ReadOnly = true;
            this.txtCommision.Size = new System.Drawing.Size(100, 22);
            this.txtCommision.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.txtBasicPay);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(this.lblBasicPay);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.txtYrsOfService);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblYrsOfService);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYrsOfService;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.TextBox txtYrsOfService;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtBasicPay;
        private System.Windows.Forms.Label lblBasicPay;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtCommision;
    }
}