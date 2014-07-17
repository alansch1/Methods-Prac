using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
	class Program
	{
		static void Main(string[] args)
		{

		int fnum = 1, snum = 2, tnum = 3, nvalue;
		int sum;
		String fname;

		sum = sumup(fnum, snum, tnum);					 //Edit > Retractor > Extract Method
		Console.WriteLine("The sum is: {0}, from {1} + {2} + {3}", sum, fnum, snum, tnum);

		sum = sumup(tnum:fnum, snum:fnum, fnum:fnum);	 //Passing fnum (1) into all the others
		Console.WriteLine("The sum is: {0}, from {1} + {2} + {3}", sum, fnum, snum, tnum);

		sum = sumupoptional(fnum);						 //Giving snum and tnum a value in the Method below
		Console.WriteLine("The sum is: {0}, from {1} + {2} + {3}", sum, fnum, snum, tnum);

		sum = sumupreference(fnum, ref snum, tnum);		 //Using reference in the Method below to assign #
		Console.WriteLine("The sum is: {0}, from {1} + {2} + {3}", sum, fnum, snum, tnum);

		makeAName(out fname);
		Console.WriteLine(fname);

}

		private static int sumup(int fnum, int snum, int tnum) 
			{
			int sum;
			fnum =10;
			sum = fnum + snum + tnum;
			return sum;
			}
	
		private static int sumupoptional(int fnum, int snum = 10, int tnum = 20) 
			{
			int sum;
			fnum =10;
			sum = fnum + snum + tnum;
			return sum;
			}
	
		private static int sumupreference(int fnum, ref int bigFatPig, int tnum) 
			{
			int sum;
			bigFatPig = 100;
			sum = fnum + bigFatPig + tnum;
			return sum;
			}

		private static void makeAName( out String myName)
		{
			myName = "Alan";

		}
	}
}


