namespace InvoiceTotal
{
	partial class frmInvoiceTotal
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
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.lblDiscPercent = new System.Windows.Forms.Label();
			this.lblDiscAmount = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtDiscPercent = new System.Windows.Forms.TextBox();
			this.txtDiscAmount = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(43, 9);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
			this.lblSubtotal.TabIndex = 0;
			this.lblSubtotal.Text = "&Subtotal:";
			// 
			// lblDiscPercent
			// 
			this.lblDiscPercent.AutoSize = true;
			this.lblDiscPercent.Location = new System.Drawing.Point(43, 41);
			this.lblDiscPercent.Name = "lblDiscPercent";
			this.lblDiscPercent.Size = new System.Drawing.Size(92, 13);
			this.lblDiscPercent.TabIndex = 1;
			this.lblDiscPercent.Text = "Discount Percent:";
			// 
			// lblDiscAmount
			// 
			this.lblDiscAmount.AutoSize = true;
			this.lblDiscAmount.Location = new System.Drawing.Point(43, 73);
			this.lblDiscAmount.Name = "lblDiscAmount";
			this.lblDiscAmount.Size = new System.Drawing.Size(91, 13);
			this.lblDiscAmount.TabIndex = 2;
			this.lblDiscAmount.Text = "Discount Amount:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(43, 105);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(34, 13);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "Total:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(146, 6);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubtotal.TabIndex = 4;
			// 
			// txtDiscPercent
			// 
			this.txtDiscPercent.Location = new System.Drawing.Point(146, 34);
			this.txtDiscPercent.Name = "txtDiscPercent";
			this.txtDiscPercent.ReadOnly = true;
			this.txtDiscPercent.Size = new System.Drawing.Size(100, 20);
			this.txtDiscPercent.TabIndex = 5;
			// 
			// txtDiscAmount
			// 
			this.txtDiscAmount.Location = new System.Drawing.Point(146, 66);
			this.txtDiscAmount.Name = "txtDiscAmount";
			this.txtDiscAmount.ReadOnly = true;
			this.txtDiscAmount.Size = new System.Drawing.Size(100, 20);
			this.txtDiscAmount.TabIndex = 6;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(146, 98);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 7;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(46, 140);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(171, 140);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(287, 180);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtDiscAmount);
			this.Controls.Add(this.txtDiscPercent);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblDiscAmount);
			this.Controls.Add(this.lblDiscPercent);
			this.Controls.Add(this.lblSubtotal);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Total";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label lblDiscPercent;
		private System.Windows.Forms.Label lblDiscAmount;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.TextBox txtDiscPercent;
		private System.Windows.Forms.TextBox txtDiscAmount;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
	}
}

