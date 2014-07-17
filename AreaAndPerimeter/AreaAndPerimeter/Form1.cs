using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
	public partial class frmAreaPerimeter : Form
	{
		
		double calculateArea;
		double calculatePerimeter;
		public frmAreaPerimeter()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			double width = Double.Parse(txtWidth.Text);
			double length = Double.Parse(txtLength.Text);
			calculateArea = length * width;
			txtArea.Text = Convert.ToString(calculateArea);

			calculatePerimeter = (length * 2) + (width * 2);
			txtPerimeter.Text = Convert.ToString(calculatePerimeter);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtLength_TextChanged(object sender, EventArgs e)
		{
			
		
		}

		private void txtWidth_TextChanged(object sender, EventArgs e)
		{
			
			
		}
	}
}
