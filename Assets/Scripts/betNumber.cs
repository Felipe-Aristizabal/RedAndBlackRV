using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

    public Text texto;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Respawn")){
            texto.gameObject.SetActive(true);
            texto.text = "Apostado";
            other.gameObject.tag = "Waste";
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("Waste")){
            texto.gameObject.SetActive(true);
            texto.text = "NO Apostado";
            other.gameObject.tag = "Respawn";
        }
    }

}
