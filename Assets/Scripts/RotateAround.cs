using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public float speed = 160f;
	public float decreaseRate = 10f;
	public bool stop = false;
	private float timer = 0f;



	void Start() {

	}


	 public void Update() 
	{
		timer += Time.deltaTime;
		if (stop && speed > 0 && timer>=10f)
		{
			speed -= decreaseRate * Time.deltaTime;
		}
		transform.RotateAround(transform.position, Vector2.down, speed * Time.deltaTime);


		if (timer >= 10f)
		{
			Debug.Log("Han pasado 10 segundos :) ");
			if (!this.stop) {
				this.stop = true;
			} else {
				if (this.speed <= 0) {
					this.stop = false;
					this.speed = 160f;
					this.timer = 0.0f;
				}
			}
		}
	}

}