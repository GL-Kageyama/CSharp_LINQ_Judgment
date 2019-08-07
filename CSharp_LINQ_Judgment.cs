using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
	class MainClass 
	{
		public static void Main(string[] args)
		{
			var jud = new JudgeClass();

			jud.GetJudge();
		}
	}

	class JudgeClass
	{
		List<int> source = new List<int>
		{
			2, 4, 6, 8, 10, 12, 14, 16
		};

		public void GetJudge()
		{
			// All()
			// 全ての要素が、条件を満たしているか判定
			Console.WriteLine(source.All(e => e >= 6));

			// Any()
			// 条件を満たす要素が含まれているか判定
			Console.WriteLine(source.Any(e => e >= 14));

			// Contains()
			// 指定した要素が含まれているか判定
			Console.WriteLine(source.Contains(11));

			// SequenceEqual()
			// 2つのシーケンスが等しいか判定
			Console.WriteLine(source.SequenceEqual( new List<int>
													{
														2, 4, 6, 8, 10, 12, 14, 16
													} ));
		}
	}
}

