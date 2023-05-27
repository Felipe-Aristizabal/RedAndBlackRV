using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wallet : MonoBehaviour {

    public Text totalMoneyText;
    public Text currentBetText;
	public Text lastBet;

    public int totalMoney;
    public int currentBet = 0;

	public string lastReportedSensor = "";
	public int captureBet; 
	public RotateAround refRotateAround;
	public int totalMoneyBet =0;
	public bool isBet = false;
	public bool rouletteStop = false;
	public string spotBet = "";


	public bool prueba = false;

	
	public string colorBetRoullete = "";
	public int numberBetRoullete = -1;
	public string colorBetTable = "";
	public int numberBetTable = -1;

	void Start () {
	    string moneyText = totalMoneyText.text;
        int.TryParse(moneyText, out totalMoney);
        currentBetText.text = currentBet.ToString();
		lastBet.text = "No ha caído nada";
		refRotateAround = GameObject.Find("RotatorRoullete").GetComponent<RotateAround>();
	}

	void Update () {
		lastBet.text = validateNumberBet(lastReportedSensor).ToString();  
		

		if (isBet == true && rouletteStop == true && lastReportedSensor != "" && spotBet != "" && currentBet != 0 && prueba == true){
			Debug.Log("Lugar mesa"+spotBet);
			Debug.Log("Reportado: "+ lastReportedSensor);
			Debug.Log("Apuesta: " + currentBet);
			if (spotBet == "Bet Red" || spotBet == "Bet Black"){
				colorBetTable = validateStringBet(spotBet);
			}
			colorBetRoullete = validateStringBet(lastReportedSensor);
			numberBetRoullete = validateNumberBet(lastReportedSensor);
			numberBetTable =  validateNumberBet(spotBet);

			if (colorBetRoullete == colorBetTable){
				Debug.Log("HAS GANADO");
				int priceBet = currentBet;
				currentBet = 0;
				currentBetText.text = currentBet.ToString();
				priceBet = priceBet * 2;
				int winBet = totalMoney + priceBet;
				totalMoneyText.text = winBet.ToString();
			} else {
				Debug.Log("NADA DE NADA");
				currentBet = 0;
				currentBetText.text = currentBet.ToString();
			}
		}
    }
	
	public void apostarEnPantalla(int ficha) {
		currentBet = currentBet + ficha;
		totalMoney = totalMoney - ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
	}

	public void unapostarEnPantalla(int ficha) {
		currentBet = currentBet - ficha;
		totalMoney = totalMoney + ficha;
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text = currentBet.ToString();
	}

	public void apostar(){
		Debug.Log("Presione el boton apostar");
		
		// roulleteRun = this.refRotateAround.stop;
		// while(roulleteRun == false){
		// 	Debug.Log("Entré al while");
			
		// 	roulleteRun = this.refRotateAround.stop;
		// 	if(roulleteRun){
		// 		Debug.Log("salio del ciclo");
		// 		break;
		// 	}
		// };
	 } 

	public int validateNumberBet(string lastReportedSensor){
		switch (lastReportedSensor){
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
