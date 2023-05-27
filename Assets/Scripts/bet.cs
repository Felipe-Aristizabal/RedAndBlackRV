using UnityEngine;


public class bet : MonoBehaviour
{
    public bool activate = false;
    private Wallet refWallet;
    private spawnChips refSpawnChips;
    GameObject[] objectsToDestroywhite;
    GameObject[] objectsToDestroygreen;
    GameObject[] objectsToDestroyred;

	void Start() {
        refWallet = GameObject.Find("AllMoney").GetComponent<Wallet>();
        refSpawnChips = GameObject.Find("Button Red").GetComponent<spawnChips>();
	}
		
    void Update(){
        objectsToDestroywhite = GameObject.FindGameObjectsWithTag("WhiteChip");
        objectsToDestroyred = GameObject.FindGameObjectsWithTag("RedChip");
        objectsToDestroygreen = GameObject.FindGameObjectsWithTag("GreenChip");
        if (activate == true){
            this.refWallet.isBet = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (objectsToDestroywhite != null) {
            foreach (GameObject objectToDestroyW in objectsToDestroywhite)
            {
                Destroy(objectToDestroyW);
            }
        }

        if (objectsToDestroygreen != null) {
            foreach (GameObject objectToDestroyG in objectsToDestroygreen)
            {
                Destroy(objectToDestroyG);
            }
        }


        if (objectsToDestroyred != null) {
            foreach (GameObject objectToDestroyR in objectsToDestroyred)
            {
                Destroy(objectToDestroyR);
            }
        }
        //Debug.Log(this.refWallet.totalMoneyBet);
        this.refWallet.isBet = true;
        this.refSpawnChips.hasGeneratedObject = false;
    }
}


