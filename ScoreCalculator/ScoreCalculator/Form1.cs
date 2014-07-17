using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
	public partial class frmScoreCalc : Form

	{
		public frmScoreCalc()

		{
			InitializeComponent();

		}

		private void btxExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			double scoreCount;
			double average;
			double score = Double.Parse(txtScore.Text);
	
			double scoreTotal = Double.Parse(txtScoreTotal.Text);
			scoreTotal = scoreTotal + score;
		}
	}
}
