using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public int speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	 void Update () {
		transform.RotateAround (transform.position, Vector2.down, speed * Time.deltaTime);
	}
}
