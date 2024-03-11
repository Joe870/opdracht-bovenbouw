using System;

namespace CompositionExample
{
	internal class Disk
	{
		public OperatingSystem operatingSystem;

		public Disk(OperatingSystem operatingSystem)
		{
			this.operatingSystem = operatingSystem;
		}
	}
}
