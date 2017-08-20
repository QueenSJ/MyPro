using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpf.MyWpf.Model {
	class GorundModel {
		public int XBox {
			get { return XBox; }
			set { this.XBox = value; }
		}

		public int YBox {
			get { return YBox; }
			set { this.YBox = value; }
		}

		public int LandMine {
			get { return LandMine; }
			set { this.LandMine = value; }
		}

		public int[][] Ground {
			get { return Ground; }
			set { this.Ground = value; }
		}

	}
}
