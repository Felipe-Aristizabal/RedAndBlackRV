using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    public Text texto;

    public Text totalMoneyText;
    public Text currentBetText;

    private int totalMoney;
    public int currentBet = 0;

    void Start()
	{
        string moneyText = totalMoneyText.text;
        int.TryParse(moneyText, out totalMoney);
        currentBetText.text = currentBet.ToString();
	}

    void OnTriggerEnter(Collider other){

        Vector3 objectPosition = transform.position;

        if (other.CompareTag("WhiteChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "WhiteBet";
            currentBet = currentBet + 1;
            totalMoney = totalMoney - 1;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();
            
            other.transform.position = objectPosition;
        }

        if (other.CompareTag("RedChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "RedBet";
            currentBet = currentBet + 5;
            totalMoney = totalMoney - 5;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();

            other.transform.position = objectPosition;
        }

        if (other.CompareTag("GreenChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "GreenBet";
            currentBet = currentBet + 10;
            totalMoney = totalMoney - 10;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();

            other.transform.position = objectPosition;
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("WhiteBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            currentBet = currentBet - 1;
            totalMoney = totalMoney + 1;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();
            other.gameObject.tag = "WhiteChip";
        }

        if (other.CompareTag("RedBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            currentBet = currentBet - 5;
            totalMoney = totalMoney + 5;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();
            other.gameObject.tag = "RedChip";
        }

        if (other.CompareTag("GreenBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            currentBet = currentBet - 10;
            totalMoney = totalMoney + 10;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();
            other.gameObject.tag = "GreenChip";
        }    
    }
}