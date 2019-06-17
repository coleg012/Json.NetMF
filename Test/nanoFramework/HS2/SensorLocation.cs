using System;

namespace Test
{
	public class SensorLocation
	{
		//public string SensorId;
		public string Area;     //broader point of sensor location, i.e. floor (bsmnt, main, upper)	
		public string Location; //narrow point of sensor location, i.e. room (LR, SWB), door (Front, back), sensor mounting point (ThPanel1, CollTankOut, ...)
	}
}
