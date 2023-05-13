using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public float speed = 60f;
	public float decreaseRate = 4f;

	void Start() {

	}

	void Update() {
		if (speed > 0) {
			speed -= decreaseRate * Time.deltaTime;
		}
		transform.RotateAround(transform.position, Vector2.down, speed * Time.deltaTime);
	}
}