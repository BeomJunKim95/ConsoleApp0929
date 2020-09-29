using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
	[Serializable]
	class Person1
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }

		public Person1(string name, string phone, int age)
		{
			Name = name;
			Phone = phone;
			Age = age;
		}
	}
	class ClassSerialize1
	{
		static void Main()
		{
			//3명저장
			Person1[] arr = new Person1[3];
			arr[0] = new Person1("김연아", "010-1111", 30);
			arr[1] = new Person1("류현진", "010-2222", 35);
			arr[2] = new Person1("손흥민", "010-1111", 29);

			//1명 저장
			//Person1 p1 = new Person1("김연아", "010-3333", 29);
			//FileStream fs = new FileStream("a.dat", FileMode.Create);
			//BinaryFormatter serializer = new BinaryFormatter();
			//serializer.Serialize(fs, p1); //Serialize(스트림, 객체)
			//fs.Close(); // 직렬화 하고 클로즈 , 스트림은 같이 쓰는게 아니다

			FileStream fs = new FileStream("b.dat", FileMode.Create);
			BinaryFormatter serializer = new BinaryFormatter();

			serializer.Serialize(fs, arr);
			fs.Close();
			Console.WriteLine("객체 직렬화 성공");

			//---------------------------------------------------------------------------------
			//Console.WriteLine("객체 직렬화 성공"); //1명저장 

			//FileStream rs = new FileStream("a.dat", FileMode.Open); //읽기전용 스트림타입 만들기
			FileStream rs = new FileStream("b.dat", FileMode.Open); //3명 저장
			//Person1 p2 = (Person1)serializer.Deserialize(rs); //1명저장
			arr = (Person1[])serializer.Deserialize(rs); //3명저장

			Console.WriteLine("객체 역직렬화 성공");

			//------------------------------------------------------------------------------------
			//Console.WriteLine(p2.Name); //1명저장
			foreach(Person1 item in arr)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
