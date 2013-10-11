﻿using DNNSelenium.Platform.Properties;
using NUnit.Framework;

namespace DNNSelenium.Platform.UpgradeTests
{
	[TestFixture]
	[Category("BVT")]
	public class BVTZLogs : Common.Tests.BVT.BVTZLogs
	{
		protected override string DataFileLocation
		{
			get { return @"UpgradeTests\" + Settings.Default.BVTDataFile; }
		}
	}
}