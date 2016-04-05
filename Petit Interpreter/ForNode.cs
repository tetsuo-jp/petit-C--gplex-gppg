using System;


namespace Petit {

	public class ForNode : ProgramNode {
		public ForNode(ExpressionNode count, ProgramNode program) {
			this.count = count;
			this.program = program;
		}

		private ExpressionNode count;
		private ProgramNode program;

		public override void Execute() {
			int length = this.count.Value;
			for (int i = 0; i < length; i++) {
				this.program.Execute();
			}
		}
	}

}
