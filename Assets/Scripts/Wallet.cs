using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wallet : MonoBehaviour {

    public Text totalMoneyText;
    public Text currentBetText;
	public Text texto;

	public Text lastBet;

    public int totalMoney;
    public int currentBet = 0;

	public string lastReportedSensor = "";

	// Use this for initialization
	void Start () {
	    string moneyText = totalMoneyText.text;
        int.TryParse(moneyText, out totalMoney);
        currentBetText.text = currentBet.ToString();
		lastBet.text = "No ha caído nada";
	}

	void Update () {
		lastBet.text = lastReportedSensor;
	}

	public void apostar(int ficha) {
		currentBet = currentBet + ficha;
		totalMoney = totalMoney - ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
		texto.gameObject.SetActive(true);
        texto.text = "Apostado";
	}

	public void unapostar(int ficha) {
		currentBet = currentBet - ficha;
		totalMoney = totalMoney + ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
		texto.gameObject.SetActive(true);
        texto.text = "No has apostado";
	}



}
