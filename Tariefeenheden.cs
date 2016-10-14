using System;

namespace Lab3
{
	public static class Tariefeenheden
	{
		/*public static String[] getStations()
		{
			return new String[] {
				"Utrecht Centraal",
				"Gouda",
				"Geldermalsen",
				"Hilversum",
				"Duivendrecht",
				"Weesp"
			};
		}
        */
		public static int getTariefeenheden(int from, int to) 
		{
			switch (from) {
			case 0:
				switch (to) {
				case 0:
					return 0;
				case 1:
					return 32;
				case 2:
					return 26;
				case 3:
					return 18;
                case 4:
					return 31;
				case 5:
					return 33;
				default:
					throw new Exception ("Unknown stations");
				}
			case 1:
				switch (to) {
				case 1:
					return 0;
				case 2:
					return 58;
				case 3:
					return 50;
				case 4:
					return 54;
                case 5:
					return 57;
				default:
					return getTariefeenheden (to, from);
				}
			case 2:
				switch (to) {
				case 2:
					return 0;
				case 3:
					return 44;
				case 4:
					return 57;
				case 5:
					return 59;
				default:
					return getTariefeenheden (to, from);
				}
			case 3:
				switch (to) {
				case 3:
					return 0;
				case 4:
					return 18;
				case 5:
					return 15;
				default:
					return getTariefeenheden (to, from);
				}
			case 4:
				switch (to) {
				case 4:
					return 0;
				case 5:
					return 3;
				default:
					return getTariefeenheden (to, from);
				}
			case 5:
				switch (to) {
				case 5:
					return 0;
				default:
					return getTariefeenheden (to, from);
				}
			default:
				throw new Exception ("Unknown stations");
			}
		}
	}
}

