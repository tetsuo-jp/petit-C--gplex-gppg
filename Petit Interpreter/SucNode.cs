using System;


namespace Petit {

	public class SucNode : ExpressionNode {
		public SucNode(ExpressionNode expression) {
			this.expression = expression;
		}

		private ExpressionNode expression;

		public override int Value {
			get { return this.expression.Value + 1; }
		}
	}

}
