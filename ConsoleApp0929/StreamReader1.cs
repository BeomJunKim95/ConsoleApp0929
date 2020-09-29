using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
	class StreamReader1
	{
		static void Main()
		{
			//using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8)) //만들때 UTF8로만들었으니 똑같이 해줘야함
			//{
			//	string content = sr.ReadToEnd(); // 읽어올 파일이 길지 않을때 ReadToEnd()사용 길때 쓰면 오래걸릴수있어서
			//	//sr.Close(); // 읽자마자 클로즈 열려있는시간은 적을수록 좋으니까
			//	//using블럭을 이용하면 close 없어도됨
			//	Console.WriteLine(content);
			//}
			using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
			{
				//string content = sr.ReadLine();
				//ReadLine : 한줄을 읽어서 string으로 반환해줌 
				//더이상 읽은게 없으면(파일의 끝) null	반환
				//while (content != null)
				//{
				//	Console.WriteLine(content);
				//	content = sr.ReadLine(); //이 코드가 아래로 오지 않으면 두줄을 읽고 한줄만 출력하게 됨
				//}
				string content;
				int cnt = 0;
				while ((content = sr.ReadLine()) != null) //위에 코드를 간단하게 만듦
				{
					
					Console.WriteLine("Line {0,2} : {1}",++cnt, content);
				}
			}
		}
	}
}
