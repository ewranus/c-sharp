﻿using System;
using System.Collections;
using UnityEngine;

namespace PubNubMessaging.Tests
{
	[IntegrationTest.DynamicTestAttribute ("TestSetAndGetGlobalState")]
	public class TestSetAndGetGlobalState: MonoBehaviour
	{
		CommonIntergrationTests common = new CommonIntergrationTests ();
		string TestName = "TestSetAndGetGlobalState";

		public IEnumerator Start ()
		{
			yield return StartCoroutine(common.DoPresenceSubscribeAndParse(false, TestName));
			UnityEngine.Debug.Log (string.Format("{0}: After StartCoroutine", TestName));
			yield return new WaitForSeconds (CommonIntergrationTests.WaitTimeBetweenCalls);

		}

	}
}
