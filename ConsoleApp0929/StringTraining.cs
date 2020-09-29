using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class StringTraining
    {
        static void Main(string[] args)
        {
			//         string s = " Hello, World! ";
			//         string t;

			//         Console.WriteLine(s.Length);
			//         Console.WriteLine(s[8]);

			//         Console.WriteLine(s.Insert(8, "C# "));
			//         Console.WriteLine(s.PadLeft(20, '.'));
			//         Console.WriteLine(s.PadRight(20, '.'));
			//         Console.WriteLine(s.Remove(6));
			//         Console.WriteLine(s.Remove(6, 7));
			//         Console.WriteLine(s.Replace('l', 'm'));
			//         Console.WriteLine(s.ToLower());
			//         Console.WriteLine(s.ToUpper());
			//         Console.WriteLine('/' + s.Trim() + '/');
			//         Console.WriteLine('/' + s.TrimStart() + '/');
			//         Console.WriteLine('/' + s.TrimEnd() + '/');

			//         string[] a = s.Split(',');
			//         foreach (var i in a)
			//             Console.WriteLine('/' + i + '/');

			//         char[] destination = new char[10];
			//         s.CopyTo(8, destination, 0, 6);
			//         Console.WriteLine(destination);

			//         Console.WriteLine('/' + s.Substring(8) + '/');
			//         Console.WriteLine('/' + s.Substring(8, 5) + '/');

			//         Console.WriteLine(s.Contains("ll"));
			//         Console.WriteLine(s.IndexOf('o'));
			//         Console.WriteLine(s.LastIndexOf('o'));
			//         Console.WriteLine(s.CompareTo("abc"));

			//         Console.WriteLine(String.Concat("Hi~", s));
			//         Console.WriteLine(String.Compare("abc", s));
			//         Console.WriteLine(t = String.Copy(s));

			//         String[] val = { "apple", "orange", "grape", "pear" };
			//         String result = String.Join(", ", val);
			//         Console.WriteLine(result);

			#region 문제1  주문번호 : yyyyMMdd일련번호5자리 (2020092900005) 를 출력하시오.
			//int serial = 5;
			//Console.WriteLine($"일련번호 : {DateTime.Now.ToString("yyyyMMdd")}{serial.ToString().PadLeft(5, '0')}");

			#region 선생님코드
			//string orderNo = DateTime.Now.ToString("yyyyMMdd") + "5".PadLeft(5, '0');
			//Console.WriteLine(orderNo);
			#endregion

			#endregion

			#region 문제2 입력받은 아이디가 6자리 이상인지 체크하시오.
			//string id;
			//Console.Write("ID를 입력해주세요 : ");
			//while (true)
			//{
			//	id = Console.ReadLine();
			//	if (IsID(id) == false)
			//	{
			//		Console.Write("6자리 이상 입력해주세요 : ");
			//	}
			//	else
			//	{
			//		Console.WriteLine("당신의 ID는 : {0}", id);
			//		break;
			//	}

			//}

			#region 선생님코드
			//string userId;
			//while (true)
			//{
			//	userId = Console.ReadLine();
			//	if (userId.Length < 6)
			//		Console.WriteLine("아이디는 6자리 이상입니다.");
			//	else
			//		break;
			//}
			//Console.WriteLine(userId);
			#endregion

			#endregion

			#region 문제3  파일명 : yyyyMMddHHmmss + 랜덤3자리(영문대문자 + 숫자)
			//string strfileName = @"C:\Users\GDC5\Pictures\image\20191024114946.jpg";
			//string fileName = strfileName.Substring(strfileName.LastIndexOf('\\')+1);
			//string[] arr = GetRandomText(3);

			//Console.WriteLine($"{fileName} : {DateTime.Now.ToString("yyyyMMddmmss")}{String.Join("", arr)}");

			#region 선생님코드
			Random rand = new Random();
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < 3; i++)
			{
				int randVal = rand.Next(0, 36);
				if (randVal < 10)
					sb.Append(randVal);
				else
					sb.Append((char)(randVal + 55));
			}
			Console.WriteLine($"{DateTime.Now.ToString("yyyyMMddmmss")}{sb.ToString()}");

			#endregion

			#endregion


		}
		static bool IsID(string id)
		{
			Regex regex = new Regex(@"^([0-9a-zA-Z]){6,}$");
			return regex.IsMatch(id);
		}
		static string[] GetRandomText(int length)
		{
			Random rand = new Random();
			string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			int temp = 0;
			string[] randomText = new string[3];
			for(int i=0; i<3; i++)
			{
				temp = rand.Next(0, input.Length);
				randomText[i] = input.Substring(temp, 1);
			}
			return randomText;
		}
	}
	
}
