using System;

namespace KMP
{
	/// <summary>
	/// 
	/// </summary>
	public class kmp
	{   
		public kmp(){}

  		/// <summary>
		/// 总匹配数目
		/// </summary>
		/// <param name="s"></param>
		/// <param name="t"></param>
		/// <returns></returns>
		public  int count(string s,string t)
		{
			int start=-t.Length;
			int count=0;
			while((start=this.index_KMP(s,start+t.Length,t))!=-1) 
				 count++;
			return count;
		}

        /// <summary>
        /// 第一个匹配位置
        /// </summary>
        /// <param name="s"></param>
        /// <param name="begin"></param>
        /// <param name="t"></param>
        /// <returns></returns>
		public  int index_KMP(string s,int  begin,string t)
		{
			int i=begin;
			int j=0;
			int [] next=new int [t.Length] ;
            this.get_next(t,next);

			while(i<s.Length && j<t.Length)
			{
				if( j==-1 || s.Substring (i,1)==t.Substring (j,1) )
				{
					i++;
					j++;
				}
				else
				{
					j=next[j];
				}
			}

            return  j>t.Length -1 ? i-t.Length:-1;
		}

		private void get_next(string t,int [] next)
		{
			int j=1;
			int k=-1;
			bool found=false;
			
            next[0]=-1;

			while(j<t.Length)
			{
                found=false;
				k=next[j-1];
				while(k!=-1 && !found)
				{
					if(t.Substring(j-1,1)==t.Substring(k,1))
					{
						found=true;
					}
					else
					{
						k=next[k];
					}
				}
				k++;
				next[j]=k;
                j++;
			}
		}
	}
}
