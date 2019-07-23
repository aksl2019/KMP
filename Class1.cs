using System;

namespace KMP
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	class Class1
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			kmp k=new kmp();

			Console.WriteLine(k.count("aaab","a"));
			//			Console.WriteLine(k.index_KMP("aaab",0,"a").ToString());
			int begin = k.index_KMP("faabbazzaa",0,"aa");
			while ( begin>0) 
			{
				Console.WriteLine(begin.ToString());
				begin=k.index_KMP("faabbazzaa",begin+1,"aa");
			}
			Console.ReadLine();
		}
	}
}
