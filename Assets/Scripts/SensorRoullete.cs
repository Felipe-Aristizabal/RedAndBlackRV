﻿using UnityEngine;
using System.Collections;

public class SensorRoullete : MonoBehaviour {

	Wallet refWallet;

	// Use this for initialization
	void Start () {
		refWallet = GameObject.Find ("AllMoney").GetComponent<Wallet> ();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "RotatorBall") {
			this.refWallet.lastReportedSensor = this.transform.name;
		}
	}
}
