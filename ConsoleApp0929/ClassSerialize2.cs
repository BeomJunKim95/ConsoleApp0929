using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
	class ClassSerialize2
	{
		static void Main()
		{
			BinaryFormatter serializer = new BinaryFormatter();

			//------------------------------------------------------------------------------------
			//파일을 읽어서 배열에 저장
			Person1[] arr = new Person1[1];
			if (File.Exists("b.dat"))
			{
				FileStream rs = new FileStream("b.dat", FileMode.Open);
				arr = (Person1[])serializer.Deserialize(rs);
				Console.WriteLine("객체 역직렬화 성공");
				foreach (Person1 item in arr)
				{
					Console.WriteLine(item.Name);
				}
				rs.Close();
			}
			int readCnt = arr.Length;

			//-------------------------------------------------------------------------------------
			//3명을 추가로 입력해서 파일에 저장
			//Person1[] new_arr = new Person1[readCnt + 3];
			Person1[] new_arr = new Person1[100];
			Array.Copy(arr, new_arr, readCnt); //6개짜리 배열을 하나 만들어 복사후 3명추가

			while (true)
			{
				string name = Console.ReadLine();
				string phone = Console.ReadLine();
				if (name.Equals("q") || phone.Equals("q"))
					break;

				int age = int.Parse(Console.ReadLine());

				new_arr[readCnt] = new Person1(name, phone, age);
				readCnt++;
			}
			//new_arr[readCnt] = new Person1("박지성", "010-3333", 40);
			//new_arr[readCnt + 1] = new Person1("안정환", "010-4444", 45);
			//new_arr[readCnt + 2] = new Person1("허재", "010-5555", 50);

			//foreach (Person1 item in new_arr)
			//{
			//	Console.WriteLine(item.Name);
			//}
			
			//------------------------------------------------------------------------------------
			FileStream fs = new FileStream("b.dat", FileMode.Create);
			serializer.Serialize(fs, new_arr);
			fs.Close();
			Console.WriteLine("객체 직렬화 성공");
		}
	}
}
