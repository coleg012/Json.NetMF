using System;

namespace Test
{
	//Mqtt publish object in format of fields and tags (i.e. InfluxDb format)
	public class FieldsTagsPublishFormat
	{
		public object[] FieldsTags { get; }
		//public SensorResult SensorResult; // fields object
		//public SensorLocation SensorLocation; //tags object

		public FieldsTagsPublishFormat()
		{
			FieldsTags = new object[2] { new SensorResult(), new SensorLocation() };
			//SensorResult = new SensorResult();
			//SensorLocation = new SensorLocation();
		}

		public void SetSensorResult(SensorResult sensorResult)
		{
			FieldsTags[0] = sensorResult;
		}

		public SensorResult GetSensorResult()
		{
			return FieldsTags[0] as SensorResult;
		}

		public void SetSensorLocation(SensorLocation sensorLocation)
		{
			FieldsTags[1] = sensorLocation;
		}

		public SensorLocation GetSensorLocation()
		{
			return FieldsTags[1] as SensorLocation;
		}

	}
}
