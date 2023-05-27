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
	public int captureBet; 
	private RotateAround refRotateAround;
	// Use this for initialization
	void Start () {
	    string moneyText = totalMoneyText.text;
        int.TryParse(moneyText, out totalMoney);
        currentBetText.text = currentBet.ToString();
		lastBet.text = "No ha caído nada";
		
	}

	void Update () {
		lastBet.text = lastReportedSensor;  
		//roulleteSpeed = refRotateAround.speed;
    }
	

	public void apostar(int ficha) {
		currentBet = currentBet + ficha;
		totalMoney = totalMoney - ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
		texto.gameObject.SetActive(true);
        texto.text = "Apostado";
		refRotateAround = GameObject.Find ("RotatorRoullete").GetComponent<RotateAround> ();
		float roulleteSpeed;
		while(true){
			roulleteSpeed = refRotateAround.speed;
			if(roulleteSpeed <=0 ){
				Debug.Log("salio del ciclo");
				break;
			}
		};
		
		
	}

	public void unapostar(int ficha) {
		currentBet = currentBet - ficha;
		totalMoney = totalMoney + ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
		texto.gameObject.SetActive(true);
        texto.text = "No has apostado";
	}

	public int validateNumberBet(string captureBet){
		switch (captureBet){
			case "Bet Red":
			return 40;
			
			case "Bet Black":
			return 41;
			
			case "Bet 1": 
			return 1;
			
			case "Bet 2": 
			return 2;
			
			case "Bet 3": 
			return 3;
			
			case "Bet 4":
			return 4; 
			
			case "Bet 5": 
			return 5;
			
			case "Bet 6": 
			return 6;
			
			case "Bet 7": 
			return 7;
			
			case "Bet 8": 
			return 8;
			
			case "Bet 9": 
			return 9;
			
			case "Bet 10": 
			return 10;
			
			case "Bet 11": 
			return 11;
			
			case "Bet 12": 
			return 12;
			
			case "Bet 13": 
			return 13;
			
			case "Bet 14": 
			return 14;
			
			case "Bet 15": 
			return 15;
			
			case "Bet 16": 
			return 16;
			
			case "Bet 17": 
			return 17;
			
			case "Bet 18": 
			return 18;
			
			case "Bet 19": 
			return 19;
			
			case "Bet 20": 
			return 20;
			
			case "Bet 21": 
			return 21;
			
			case "Bet 22": 
			return 22;
			
			case "Bet 23": 
			return 23;
			
			case "Bet 24": 
			return 24;
			
			case "Bet 25": 
			return 25;
			
			case "Bet 26": 
			return 26;
			
			case "Bet 27": 
			return 27;
			
			case "Bet 28": 
			return 28;
			
			case "Bet 29": 
			return 29;
			
			case "Bet 30": 
			return 30;
			
			case "Bet 31": 
			return 31;
			
			case "Bet 32": 
			return 32;
			
			case "Bet 33": 
			return 33;
			
			case "Bet 34": 
			return 34;
			
			case "Bet 35": 
			return 35;
			
			case "Bet 36": 
			return 36;
			
			case "Bet 00": 
			return 37;
			
			case "Bet 0": 
			return 0;

			default:
			return -1;
			
		}
	}
		public string validateStringBet(string captureBet){
		switch (captureBet){
			case "Bet Red":
			return "red";
			
			case "Bet Black":
			return "black";
			
			case "Bet 1": 
			return "red";
			
			case "Bet 2": 
			return "black";
			
			case "Bet 3": 
			return "red";
			
			case "Bet 4":
			return "black"; 
			
			case "Bet 5": 
			return "red";
			
			case "Bet 6": 
			return "black";
			
			case "Bet 7": 
			return "red";
			
			case "Bet 8": 
			return "black";
			
			case "Bet 9": 
			return "red";
			
			case "Bet 10": 
			return "black";
			
			case "Bet 11": 
			return "black";
			
			case "Bet 12": 
			return "red";
			
			case "Bet 13": 
			return "black";
			
			case "Bet 14": 
			return "red";
			
			case "Bet 15": 
			return "black";
			
			case "Bet 16": 
			return "red";
			
			case "Bet 17": 
			return "black";
			
			case "Bet 18": 
			return "red";
			
			case "Bet 19": 
			return "red";
			
			case "Bet 20": 
			return "black";
			
			case "Bet 21": 
			return "red";
			
			case "Bet 22": 
			return "black";
			
			case "Bet 23": 
			return "red";
			
			case "Bet 24": 
			return "black";
			
			case "Bet 25": 
			return "red";
			
			case "Bet 26": 
			return "black";
			
			case "Bet 27": 
			return "red";
			
			case "Bet 28": 
			return "black";
			
			case "Bet 29": 
			return "black";
			
			case "Bet 30": 
			return "red";
			
			case "Bet 31": 
			return "black";
			
			case "Bet 32": 
			return "red";
			
			case "Bet 33": 
			return "black";
			
			case "Bet 34": 
			return "red";
			
			case "Bet 35": 
			return "black";
			
			case "Bet 36": 
			return "red";
			
			case "Bet 00": 
			return "green";
			
			case "Bet 0": 
			return "green";
			
			default:
			return "nada";
		}
	}
}
