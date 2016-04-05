using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Petit {

	partial class Parser {
		private Parser() : base(null) { }

		internal ProgramNode root;

		public static ProgramNode GetAbstractSyntaxTree(string input) {
			Parser parser = new Parser();
			Scanner scanner = new Scanner();

			scanner.SetSource(input, 0);
			parser.Scanner = scanner;

			parser.Parse();
			if (parser.root == null) {
				throw new FormatException("構文エラーです。");
			}
			return parser.root;
		}
	}

}
