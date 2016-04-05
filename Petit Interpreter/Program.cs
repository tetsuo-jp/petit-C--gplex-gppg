using System;
using System.IO;


namespace Petit {

	class Program {
		static void Main(string[] args) {
			do {
				if (1 < args.Length) {
					Console.Error.WriteLine("コマンドライン引数が多すぎます。");
					break;
				}
				string input = 0 < args.Length ? File.ReadAllText(args[0]) : Console.ReadLine();
				try {
					Parser.GetAbstractSyntaxTree(input).Execute();
				}
				catch (Exception e) {
					Console.Error.WriteLine("エラー: {0}", e.Message);
				}
			} while (args.Length == 0);
		}
	}

}
