using UnityEngine;

public class bet : MonoBehaviour
{
    GameObject[] objectsToDestroy;
    public betNumber betNumberScript;

    void Update(){
        objectsToDestroy = GameObject.FindGameObjectsWithTag("Waste");
    }

    void OnCollisionEnter(Collision col)
    {
        foreach (GameObject objectToDestroy in objectsToDestroy)
        {
            Destroy(objectToDestroy);
        }
        betNumberScript.texto.text = "No Apostado";
    }
}
