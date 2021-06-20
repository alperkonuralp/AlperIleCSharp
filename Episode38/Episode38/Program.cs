using System;

namespace Episode38
{
	class Program
	{
		static void Main(string[] args)
		{
			A a = new A();
			B b = new B();
			C c = new C();

			a.Write("Hello World!");
			b.Write("Hello World!");
			b.WriteLine("Hello World!");

			c.WriteLine("Hello World!");
		}
	}

	public class A
	{
		public void Write(string msg)
		{
			Console.WriteLine(msg);
		}
	}

	public class B : A
	{
		new public void Write(string msg)
		{
			Console.WriteLine("Msg = " + msg);
		}

		public void WriteLine(string msg)
		{
			base.Write(msg);
		}
	}

	public class C  : B
	{
		new public void WriteLine(string msg)
		{
			base.Write(msg);
		}
	}
}
