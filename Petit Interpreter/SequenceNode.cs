using System;


namespace Petit {

	public class SequenceNode : ProgramNode {
		public SequenceNode(ProgramNode former, ProgramNode latter) {
			this.former = former;
			this.latter = latter;
		}

		private ProgramNode former, latter;

		public override void Execute() {
			this.former.Execute();
			this.latter.Execute();
		}
	}

}
