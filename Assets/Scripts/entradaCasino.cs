using UnityEngine;
using UnityEngine.SceneManagement;

public class entradaCasino : MonoBehaviour
{
    public string sceneName = "mainScene";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MiObjeto"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
