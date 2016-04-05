using System;
using System.Collections.Generic;


namespace Petit {

	public class VariableNode : ExpressionNode {
		// 環境：識別子→記憶場所，記憶域：記憶場所→値
		// 状態：識別子→値
		internal static Dictionary<char, int> value = new Dictionary<char, int>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public VariableNode(char id) {
			this.id = id;
		}

		private char id;

		public void Set(int value) {
			VariableNode.value[this.id] = value;
		}

		public override int Value {
			get {
				if (VariableNode.value.ContainsKey(this.id)) {
					return VariableNode.value[this.id];
				}
				throw new InvalidOperationException(string.Format("未初期化の変数 {0} から値を取得しようとしました。", this.id));
			}
		}

		public override string ToString() {
			return this.id.ToString();
		}
	}

}
