using UnityEngine;

public class bet : MonoBehaviour
{
    GameObject[] objectsToDestroywhite;
    GameObject[] objectsToDestroygreen;
    GameObject[] objectsToDestroyred;
    public betNumber betNumberScript;

    void Update(){
        objectsToDestroywhite = GameObject.FindGameObjectsWithTag("WhiteBet");
        objectsToDestroyred = GameObject.FindGameObjectsWithTag("RedBet");
        objectsToDestroygreen = GameObject.FindGameObjectsWithTag("GreenBet");
    }

    void OnCollisionEnter(Collision col)
    {
        foreach (GameObject objectToDestroyW in objectsToDestroywhite)
        {
            Destroy(objectToDestroyW);
        }
        betNumberScript.texto.text = "No Apostado";

         foreach (GameObject objectToDestroyG in objectsToDestroygreen)
        {
            Destroy(objectToDestroyG);
        }
        betNumberScript.texto.text = "No Apostado";

         foreach (GameObject objectToDestroyR in objectsToDestroyred)
        {
            Destroy(objectToDestroyR);
        }
        betNumberScript.texto.text = "No Apostado";
    }
}
