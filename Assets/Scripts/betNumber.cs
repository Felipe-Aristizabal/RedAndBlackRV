using UnityEngine;
using UnityEngine.UI;

public class betNumber : MonoBehaviour {

public Text texto;

void OnTriggerEnter(Collider other){
    if (other.CompareTag("Respawn")){
        texto.gameObject.SetActive(true);
        texto.text = "Apostado";
    }
}

void OnTriggerExit(Collider other){
    if (other.CompareTag("Respawn")){
        texto.gameObject.SetActive(true);
        texto.text = "NO Apostado";
    }
}

}