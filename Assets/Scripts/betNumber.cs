using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    private Wallet refWallet;

    void Start()
	{
        this.refWallet = GameObject.Find("AllMoney").GetComponent<Wallet>();
	}

    void OnTriggerEnter(Collider other){

        Vector3 objectPosition = transform.position;

        if (other.CompareTag("WhiteChip")){
            this.refWallet.apostar(1);
            other.transform.position = objectPosition;
        }

        if (other.CompareTag("RedChip")){
            this.refWallet.apostar(5);
            other.transform.position = objectPosition;
        }

        if (other.CompareTag("GreenChip")){
            this.refWallet.apostar(10);
            other.transform.position = objectPosition;
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