using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    public Text texto;
    private int totalMoney = 25;
    public int currentBet = 0;

    public Text totalMoneyText;
    public Text currentBetText;
    
    public GameObject redButton;
    public GameObject greenButton;
    public GameObject whiteButton;



    void Start()
	{
         totalMoneyText.text =  totalMoney.ToString();
         currentBetText.text = currentBet.ToString();
    
	}

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("WhiteChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "WhiteBet";
            currentBet= currentBet+1;
            totalMoney= totalMoney-1;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();

        }
        if (other.CompareTag("GreenChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "GreenBet";
            currentBet= currentBet+10;
            totalMoney= totalMoney-10;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();

        }
        if (other.CompareTag("RedChip")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "RedBet";
            currentBet= currentBet+5;
            totalMoney= totalMoney-5;
            totalMoneyText.text = totalMoney.ToString();
            currentBetText.text = currentBet.ToString();

        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("WhiteBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            other.gameObject.tag = "WhiteChip";
        }

         if (other.CompareTag("GreenBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            other.gameObject.tag = "GreenChip";
        }

         if (other.CompareTag("RedBet")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            other.gameObject.tag = "RedChip";
        }
    }
    
    
    public void PlaceBet(int betAmount)
	{
		if (totalMoney >= betAmount)
		{
			totalMoney -= betAmount;
			currentBet += betAmount;
			UpdateUI();

            if (totalMoney == 0)
            {
                redButton.SetActive(false);
                greenButton.SetActive(false);
                whiteButton.SetActive(false);
            }
		}
	}

	private void UpdateUI()
	{
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text =  currentBet.ToString();
	}
}