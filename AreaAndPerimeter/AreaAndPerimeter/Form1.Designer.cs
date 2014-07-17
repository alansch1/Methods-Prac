namespace AreaAndPerimeter
{
	partial class frmAreaPerimeter
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
			this.lblLength = new System.Windows.Forms.Label();
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblArea = new System.Windows.Forms.Label();
			this.lblPerimeter = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Location = new System.Drawing.Point(54, 41);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(43, 13);
			this.lblLength.TabIndex = 0;
			this.lblLength.Text = "Length:";
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(54, 71);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(38, 13);
			this.lblWidth.TabIndex = 0;
			this.lblWidth.Text = "Width:";
			// 
			// lblArea
			// 
			this.lblArea.AutoSize = true;
			this.lblArea.Location = new System.Drawing.Point(54, 101);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(32, 13);
			this.lblArea.TabIndex = 0;
			this.lblArea.Text = "Area:";
			// 
			// lblPerimeter
			// 
			this.lblPerimeter.AutoSize = true;
			this.lblPerimeter.Location = new System.Drawing.Point(54, 131);
			this.lblPerimeter.Name = "lblPerimeter";
			this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
			this.lblPerimeter.TabIndex = 0;
			this.lblPerimeter.Text = "Perimeter:";
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(138, 33);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(100, 20);
			this.txtLength.TabIndex = 1;
			this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
			// 
			// txtPerimeter
			// 
			this.txtPerimeter.Location = new System.Drawing.Point(138, 128);
			this.txtPerimeter.Name = "txtPerimeter";
			this.txtPerimeter.ReadOnly = true;
			this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
			this.txtPerimeter.TabIndex = 0;
			this.txtPerimeter.TabStop = false;
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(138, 94);
			this.txtArea.Name = "txtArea";
			this.txtArea.ReadOnly = true;
			this.txtArea.Size = new System.Drawing.Size(100, 20);
			this.txtArea.TabIndex = 0;
			this.txtArea.TabStop = false;
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(138, 64);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(100, 20);
			this.txtWidth.TabIndex = 2;
			this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(13, 166);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(128, 166);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmAreaPerimeter
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(303, 201);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.txtPerimeter);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.lblPerimeter);
			this.Controls.Add(this.lblArea);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.lblLength);
			this.Name = "frmAreaPerimeter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Area And Perimeter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Label lblPerimeter;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.TextBox txtPerimeter;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
	}
}

