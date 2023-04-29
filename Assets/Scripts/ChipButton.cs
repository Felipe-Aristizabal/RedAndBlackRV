using UnityEngine;
using UnityEngine.UI;

public class ChipButton : MonoBehaviour
{
    public int chipValue;
    private BetController betController;

    void Start()
    {
        betController = GameObject.FindObjectOfType<BetController>();
        GetComponent<Button>().onClick.AddListener(PlaceBet);
    }

    void PlaceBet()
    {
        betController.PlaceBet(chipValue);
    }
}