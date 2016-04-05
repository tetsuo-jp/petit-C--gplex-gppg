using System;


namespace Petit {

	public class AssignNode : ProgramNode {
		public AssignNode(VariableNode variable, ExpressionNode expression) {
			this.variable = variable;
			this.expression = expression;
		}

		private VariableNode variable;
		private ExpressionNode expression;

		public override void Execute() {
			this.variable.Set(this.expression.Value);
			Console.WriteLine("Variable {0} becomes {1}.", this.variable, this.variable.Value);
		}
	}

}
