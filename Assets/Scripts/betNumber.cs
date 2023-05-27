using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    private Wallet refWallet;
    private RotateAround refRotateAround;
    void Start()
	{
        this.refWallet = GameObject.Find("AllMoney").GetComponent<Wallet>();
	}

    void OnTriggerEnter(Collider other){

        Vector3 objectPosition = transform.position;
        
        if (other.CompareTag("WhiteChip")){
            this.refWallet.apostarEnPantalla(1);
            this.refWallet.totalMoneyBet += 1;
            other.transform.position = objectPosition;
        }

        if (other.CompareTag("RedChip")){
            this.refWallet.apostarEnPantalla(5);
            this.refWallet.totalMoneyBet += 5;
            other.transform.position = objectPosition;
        }
        if (other.CompareTag("GreenChip")){
            this.refWallet.apostarEnPantalla(10);
            this.refWallet.totalMoneyBet += 10;
            other.transform.position = objectPosition;  
        }

        this.refWallet.spotBet = gameObject.name;
    
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("WhiteChip")){
            this.refWallet.unapostarEnPantalla(1);
            this.refWallet.totalMoneyBet -= 1;
        }

        if (other.CompareTag("RedChip")){
            this.refWallet.unapostarEnPantalla(5);
            this.refWallet.totalMoneyBet -= 5;
        }

        if (other.CompareTag("GreenChip")){
            this.refWallet.unapostarEnPantalla(10);
            this.refWallet.totalMoneyBet -= 10;
        }    
    }
}