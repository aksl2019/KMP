using System;

namespace KMP
{
	/// <summary>
	/// Class1 ��ժҪ˵����
	/// </summary>
	class Class1
	{
		/// <summary>
		/// Ӧ�ó��������ڵ㡣
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
