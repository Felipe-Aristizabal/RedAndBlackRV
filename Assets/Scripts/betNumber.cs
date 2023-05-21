using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    private Wallet refWallet;
    private RotateAround refRotateAround;
    void Start()
	{
        this.refWallet = GameObject.Find("AllMoney").GetComponent<Wallet>();
        refRotateAround = GameObject.Find ("RotatorRoullete").GetComponent<RotateAround> ();
	}
    void Update () {
         float roulleteSpeed = this.refRotateAround.speed;
    }

    void OnTriggerEnter(Collider other){

        Vector3 objectPosition = transform.position;

        if (other.CompareTag("WhiteChip")){
            this.refWallet.apostar(1);
            other.transform.position = objectPosition;
            this.refWallet.captureBet = this.refWallet.validateNumberBet(this.transform.name);
        }

        if (other.CompareTag("RedChip")){
            this.refWallet.apostar(5);
            other.transform.position = objectPosition;
            this.refWallet.captureBet = this.refWallet.validateNumberBet(this.transform.name);
        }

        if (other.CompareTag("GreenChip")){
            this.refWallet.apostar(10);
            other.transform.position = objectPosition;
            this.refWallet.captureBet = this.refWallet.validateNumberBet(this.transform.name);
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("WhiteChip")){
            this.refWallet.unapostar(1);
        }

        if (other.CompareTag("RedChip")){
            this.refWallet.unapostar(5);
        }

        if (other.CompareTag("GreenChip")){
            this.refWallet.unapostar(10);
        }    
    }
}