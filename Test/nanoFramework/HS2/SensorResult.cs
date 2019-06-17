using System;


namespace Test
{
	//Result of sensor reading
	public class SensorResult
	{
		public object Value;     //sensor read value, could be float for temp. sensor or bool for toggle sensor
														 //todo: see later if we need precise mesurement time, i.e. if mqtt brocker is down, and then up some time later and we need original time of mesurement, not the time of receiving it on broker
														 //public uint TimeMs;     //time since epoch(1970?) of mesurament, in ms 
	}
}
