using UnityEngine;
using UnityEngine.SceneManagement;

public class casinoOut : MonoBehaviour
{
    public string sceneName = "initScene";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MiObjeto"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}