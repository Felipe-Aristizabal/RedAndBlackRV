using UnityEngine;
using UnityEngine.UI;

public class BetController : MonoBehaviour
{
    public int totalMoney = 100;
    public int currentBet = 0;

    public Text totalMoneyText;
    public Text currentBetText;

	void Start()
	{
    totalMoneyText.text =  totalMoney.ToString();
    currentBetText.text = currentBet.ToString();
	}

	public void PlaceBet(int betAmount)
	{
		if (totalMoney >= betAmount)
		{
			totalMoney -= betAmount;
			currentBet += betAmount;
			UpdateUI();
			}
	}

	private void UpdateUI()
	{
		totalMoneyText.text = totalMoney.ToString();
		currentBetText.text =  currentBet.ToString();
	}
}
