using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ASP.NET_Lesson_2
{
	internal class ShowDataMessageBox : IShowData
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		public static extern int MessageBox(IntPtr h, string m, string c, int type);
		
		public void ShowData(string movie_string)
		{
			MessageBox((IntPtr)0, movie_string, "Фильм", 0);
		}
	}
}
