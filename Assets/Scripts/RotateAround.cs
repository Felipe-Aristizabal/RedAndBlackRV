using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public float speed;
	public float decreaseRate = 10f;
	public bool stop = false;
	private float timer = 0f;
	private Wallet refWallet;

	void Start() {
		refWallet = GameObject.Find("AllMoney").GetComponent<Wallet>();
		speed = Random.Range(140f, 180f);
	}

	 public void Update() 
	{
		timer += Time.deltaTime;
		if (!stop && speed > 0 && timer>=3f)
		{
			speed -= decreaseRate * Time.deltaTime;
			if (speed <= 0) {
				this.refWallet.rouletteStop = true;
			}
		}
		if(!stop && speed >0){
			transform.RotateAround(transform.position, Vector2.down, speed * Time.deltaTime);
			this.refWallet.rouletteStop = false;
		} 

		if (timer >= 20f) 
		{
			// Debug.Log("Han pasado 10 segundos :) ");
			if (!this.stop) {
				this.stop = true;
			} else {
				if (this.speed <= 0) {
					this.stop = false;
					this.speed = Random.Range(140f, 180f);
					this.timer = 0.0f;
				}
			}
		}
	}

}