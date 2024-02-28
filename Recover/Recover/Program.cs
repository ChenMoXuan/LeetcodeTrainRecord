#define Unity320
#define Unity20
#undef Unity320

using System.Collections;
using System.Net.Mail;

namespace Recover
{
	delegate int MyFun();
	#region 泛型
	class Test
	{
		public event Func<int> a = () => { Console.WriteLine("eeeeee");return 0; };
		public void FuncTest<K>(K str) where K : class
		{
			Console.WriteLine(str);
		}

		public K FuncTest<K>(string v)
		{
			return default(K);
		}

		public void FuncTest<K>()
		{
			K t = default(K);
			Console.WriteLine(t);
		}

		public void Do()
		{
			a();
		}
	}
	#endregion

	class CustomList<T> : IEnumerable<T>, IEnumerator<T>
	{
		private List<T> list;

		public T Current => throw new NotImplementedException();

		object IEnumerator.Current => throw new NotImplementedException();

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			//Test t = new Test();
			//t.a += Speed;
			//t.Do();


			//MyFun f = Speed2;
			//f += Speed;
			//f.Invoke();

			//Console.WriteLine(TestFun(1)(2));

			//Thread t = new Thread(TestThread);
			//t.Start();

			int a = 10;
			Type type = a.GetType();

			Console.WriteLine(type);
			Console.WriteLine(type.Assembly);
		}

		static int Speed()
		{
			string name = "shiba";
			int age = 18;
			Console.WriteLine($"haha{name},{age}");
			return 1;
		}

		static int Speed2()
		{
			Console.WriteLine("2");
			return 2;
		}

		static Func<int, int> TestFun(int i)
		{
			return (v) => { return i * v; };
		}


		static void TestThread()
		{
			Console.WriteLine("线程开启了");
		}
	}
}