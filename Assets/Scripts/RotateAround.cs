using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public float speed = 160f;
	public float decreaseRate = 10f;
	public bool shouldRotate = false;
	private float timer = 0f;


	void Start() {

	}


	 public void Update() 
	{
		timer += Time.deltaTime;
		if (shouldRotate && speed > 0 && timer>=10f)
		{
			speed -= decreaseRate * Time.deltaTime;
		}
		transform.RotateAround(transform.position, Vector2.down, speed * Time.deltaTime);


		if (timer >= 10f)
		{
			Debug.Log("Han pasado 10 segundos :) ");

		}
	}
}