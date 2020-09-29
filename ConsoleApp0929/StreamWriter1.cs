using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp0929
{
	class StreamWriter1
	{
		[STAThread] //싱글스레드 : 이 어트리뷰트를 줘야 실행가능
		static void Main()
		{
			//string path = System.Environment.CurrentDirectory = "C:\\"; //exe 파일이 만들어지는 폴더경로를 찍어주는 속성
			//C: \Users\GDC6\source\repos\ConsoleApp0929\ConsoleApp0929\bin\Debug
			//CurrentDirectory 속성은 Get Set다되서 내가 바꿀수도있다

			// System.Window.Forms참조추가
			//SaveFileDialog dlg = new SaveFileDialog();
			////DialogResult result = dlg.ShowDialog(); //DialogResult타입을 사용해 저장과 취소를 눌렀을때 저장과 취소 구분
			//if (/*result*/dlg.ShowDialog() == DialogResult.OK) //OK : 제대로 저장을 눌렀을때 , 없으면 저장할때 취소를 누르면 오류가뜸
			//{												   //일반적인 코딩
			//	string fileName = dlg.FileName;
			string fileName = "test.log";
			//StreamWriter sw = new StreamWriter("test.log", true, Encoding.UTF8); //생성자가 8개나된다
			//StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8);
			using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))//어펜드가 true이기 때문에 계속 덮어쓰기가능
																						 //false면 오버라이트 : 지우고 새로운 덮어쓰기
				// Using블럭을 쓰면 이블럭이 끝나면 자동으로 자원이 해제됨 그러므로 close를 안써도된다
				// 파일과 DB에서 자주쓰게됨
				{
					sw.WriteLine("안녕하세요. {0}님.", "홍길동");
					sw.WriteLine(123456);
					sw.WriteLine("ABCabc");
					sw.Flush();
					//sw.Close(); //using 블럭을쓰면 자동으로 자원을 해제해주기 때문에 필요없음
				}
			//}
		}
	}
}
