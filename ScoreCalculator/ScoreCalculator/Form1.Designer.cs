namespace ScoreCalculator
{
	partial class frmScoreCalc
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
			this.lblScore = new System.Windows.Forms.Label();
			this.lblScoreTotal = new System.Windows.Forms.Label();
			this.lblScoreCount = new System.Windows.Forms.Label();
			this.lblAverage = new System.Windows.Forms.Label();
			this.txtScore = new System.Windows.Forms.TextBox();
			this.txtScoreTotal = new System.Windows.Forms.TextBox();
			this.txtScoreCount = new System.Windows.Forms.TextBox();
			this.txtAverage = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btxExit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(29, 46);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(38, 13);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "Score:";
			// 
			// lblScoreTotal
			// 
			this.lblScoreTotal.AutoSize = true;
			this.lblScoreTotal.Location = new System.Drawing.Point(29, 82);
			this.lblScoreTotal.Name = "lblScoreTotal";
			this.lblScoreTotal.Size = new System.Drawing.Size(65, 13);
			this.lblScoreTotal.TabIndex = 1;
			this.lblScoreTotal.Text = "Score Total:";
			// 
			// lblScoreCount
			// 
			this.lblScoreCount.AutoSize = true;
			this.lblScoreCount.Location = new System.Drawing.Point(29, 118);
			this.lblScoreCount.Name = "lblScoreCount";
			this.lblScoreCount.Size = new System.Drawing.Size(69, 13);
			this.lblScoreCount.TabIndex = 2;
			this.lblScoreCount.Text = "Score Count:";
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.Location = new System.Drawing.Point(29, 154);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(50, 13);
			this.lblAverage.TabIndex = 3;
			this.lblAverage.Text = "Average:";
			// 
			// txtScore
			// 
			this.txtScore.Location = new System.Drawing.Point(147, 38);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(100, 20);
			this.txtScore.TabIndex = 4;
			// 
			// txtScoreTotal
			// 
			this.txtScoreTotal.Location = new System.Drawing.Point(147, 75);
			this.txtScoreTotal.Name = "txtScoreTotal";
			this.txtScoreTotal.ReadOnly = true;
			this.txtScoreTotal.Size = new System.Drawing.Size(100, 20);
			this.txtScoreTotal.TabIndex = 5;
			// 
			// txtScoreCount
			// 
			this.txtScoreCount.Location = new System.Drawing.Point(147, 111);
			this.txtScoreCount.Name = "txtScoreCount";
			this.txtScoreCount.ReadOnly = true;
			this.txtScoreCount.Size = new System.Drawing.Size(100, 20);
			this.txtScoreCount.TabIndex = 6;
			// 
			// txtAverage
			// 
			this.txtAverage.Location = new System.Drawing.Point(147, 147);
			this.txtAverage.Name = "txtAverage";
			this.txtAverage.ReadOnly = true;
			this.txtAverage.Size = new System.Drawing.Size(100, 20);
			this.txtAverage.TabIndex = 7;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(61, 190);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear Scores";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btxExit
			// 
			this.btxExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btxExit.Location = new System.Drawing.Point(223, 190);
			this.btxExit.Name = "btxExit";
			this.btxExit.Size = new System.Drawing.Size(75, 23);
			this.btxExit.TabIndex = 9;
			this.btxExit.Text = "E&xit";
			this.btxExit.UseVisualStyleBackColor = true;
			this.btxExit.Click += new System.EventHandler(this.btxExit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(304, 36);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmScoreCalc
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btxExit;
			this.ClientSize = new System.Drawing.Size(391, 232);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btxExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtAverage);
			this.Controls.Add(this.txtScoreCount);
			this.Controls.Add(this.txtScoreTotal);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.lblAverage);
			this.Controls.Add(this.lblScoreCount);
			this.Controls.Add(this.lblScoreTotal);
			this.Controls.Add(this.lblScore);
			this.Name = "frmScoreCalc";
			this.Text = "Score Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblScoreTotal;
		private System.Windows.Forms.Label lblScoreCount;
		private System.Windows.Forms.Label lblAverage;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.TextBox txtScoreTotal;
		private System.Windows.Forms.TextBox txtScoreCount;
		private System.Windows.Forms.TextBox txtAverage;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btxExit;
		private System.Windows.Forms.Button btnAdd;
	}
}

