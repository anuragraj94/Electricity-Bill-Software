namespace Electricity_Bill
{
    partial class frm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(110, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(158, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Electricity Bill";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(59, 95);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(136, 17);
            this.lblPrevious.TabIndex = 1;
            this.lblPrevious.Text = "Previous Reading";
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(204, 96);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(100, 20);
            this.txtPrevious.TabIndex = 2;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(204, 122);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 4;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(59, 121);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(127, 17);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Current Reading";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(204, 148);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 6;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(59, 147);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(127, 17);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Per Unit Rupees";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(108, 213);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(204, 213);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(203, 175);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(58, 174);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(125, 17);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Payable Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 36);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(50, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 136);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 23);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 273);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

