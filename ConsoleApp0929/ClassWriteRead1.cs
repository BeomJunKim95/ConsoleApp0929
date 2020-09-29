using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{	//내가만든 클래스 타입을 파일에 어떻게 쓰는지 
	class Person
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }

		public Person(string name, string phone, int age)
		{
			Name = name;
			Phone = phone;
			Age = age;
		}

		public override string ToString()
		{
			//return $"Name : {Name}\nPhone : {Phone}\nAge : {Age}\n"; 
			return $" {Name}|{Phone}|{Age}"; //객체로 저장하기 위해 구분자를 추가
		}
	}
	class ClassWriteRead1
	{
		static void Main()
		{
			Person p1 = new Person("김연아", "010-1111", 30);
			Person p2 = new Person("류현진", "010-2222", 35);

			
			//Console.WriteLine(p1);
			//Console.WriteLine(p2.ToString());

			//using (StreamWriter sw = new StreamWriter("PersonInfo.txt", true, Encoding.Default)) //파일을 쓸거면 StreamWriter
			//{
			//	sw.WriteLine(p1.ToString());
			//	sw.WriteLine(p2.ToString());
			//	sw.Flush();
			//}
			//Console.WriteLine("저장이 완료되었습니다.");

			//using(StreamReader sr = new StreamReader("PersonInfo.txt", Encoding.Default)) //읽기와 쓰기는 따로
			//{
			//	string person;
			//	while ((person = sr.ReadLine()) != null)
			//	{
			//		Console.WriteLine(person);
			//	}
			//}
			//Console.WriteLine("읽기가 완료되었습니다.");
			//하지만 이렇게 쓰고 읽는거는 그냥 문자열일 뿐이다 객체를 저장하고싶을땐 어떻게 하면 될까?
			//저장된 파일을 가지고 다시 객체를 만들려면 이방법으로는 불가능
			//그래서 직렬화를 해야하는데 일단 직렬화를 하지않고 해보자(치선책)
			using (StreamWriter sw = new StreamWriter("PersonInfo.txt", true, Encoding.Default)) //파일을 쓸거면 StreamWriter
			{
				sw.WriteLine(p1.ToString());
				sw.WriteLine(p2.ToString());
				sw.Flush();
			}
			Console.WriteLine("저장이 완료되었습니다.");

			using (StreamReader sr = new StreamReader("PersonInfo.txt", Encoding.Default)) //읽기와 쓰기는 따로
			{
				string person;
				while ((person = sr.ReadLine()) != null)
				{
					Console.WriteLine(person);
					string[] per = person.Split('|'); // 문자열로 받아 스플릿을 사용해 객체로 다시 만듦
					if (per.Length == 3)
					{
						Person per1 = new Person(per[0], per[1], int.Parse(per[2]));//그리고 다시 내가 원하는 타입으로 new
						Console.WriteLine(per1.Name);
					}
				}
			}
			Console.WriteLine("읽기가 완료되었습니다.");
		}
	}
}
