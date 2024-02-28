using System.Linq;

namespace 爬楼梯
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(ClimbStairs(5));
		}

		public static int ClimbStairs(int n)
		{

			if (n == 1) return 1;
			if (n == 2) return 2;

			List<int> num = new List<int>();
			num.Add(1);
			num.Add(2);

			//循环次数代表执行次数
			for (int i = 0; i < n-2; i++)
			{
				num.Add(num[num.Count-1]+ num[num.Count - 2]);
			}

			return num[num.Count - 1];
		}
	}
}