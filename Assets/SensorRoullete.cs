using UnityEngine;
using System.Collections;

public class SensorRoullete : MonoBehaviour {

	Wallet refWallet;
	RotateAround refRotateAround;

	// Use this for initialization
	void Start () {
		refWallet = GameObject.Find ("AllMoney").GetComponent<Wallet> ();
	}
	
	// Update is called once per frame
	void Update () {
		refRotateAround = GameObject.Find ("RotatorRoullete").GetComponent<RotateAround> ();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "RotatorBall") {
			this.refWallet.lastReportedSensor = this.transform.name;
		}
	}
}
