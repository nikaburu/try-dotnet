using System;
using System.Collections.Generic;
using static System.Console; //!! Using static !!

namespace Try.Dotnet.Lib
{
	public class Csharp6
	{
		public Csharp6(string b)
		{
			Bar = b;
		}

		public string Bar { get; }

		public Dictionary<int, string> Numbers { get; } =
			new Dictionary<int, string> {[7] = "seven", [9] = "nine", [13] = "thirteen"}; //!! Index initializers !!

		public string GetterOnlyAutoProperty { get; } =
			nameof(Csharp6); //!! Immutable property !!

		public string ExpressionBodiesProperty => GetterOnlyAutoProperty;

		public void ExpressionBodiesMethod() => WriteLine($"Ello: funccc");

		public void BarAct(bool isFoo = true)
		{
			try
			{
				List<int> nullConditionalAccessToIndexer = null;
				var element = nullConditionalAccessToIndexer?[0] ?? 0;

				throw new Exception("test C# 6 Exception filters");
			}
			catch (Exception exception) when (exception?.Message != null && isFoo
			) //!! Null-conditional operators and Exception filters !!
			{
				WriteLine($"Exception: {exception.Message}! Method name is {nameof(BarAct)}, parameter name is {nameof(isFoo)}");
				//!! String interpolation and nameof expressions !!
			}
		}
	}
}