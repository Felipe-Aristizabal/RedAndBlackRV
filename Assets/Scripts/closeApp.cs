using UnityEngine;
using System.Collections;

public class closeApp : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MiObjeto"))
        {
            Application.Quit();
        }
    }
}

