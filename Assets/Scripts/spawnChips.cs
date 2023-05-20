using UnityEngine;
using System.Collections;

public class spawnChips : MonoBehaviour
{
    // Referencia al prefab que queremos instanciar
    public GameObject objetoPrefab;

    void OnCollisionEnter(Collision col)
    {
        // Verificamos si el objeto que colisionó tiene la etiqueta "MiObjeto"
        if (col.gameObject.CompareTag("MiObjeto"))
        {
           // Creamos una nueva instancia del objeto prefab en la posición (0, 0, 0) y sin rotación
            GameObject objeto = (GameObject) Instantiate(objetoPrefab);
            Vector3 newPosition = new Vector3(0.37f, 0.273f, -2.184f);
            objeto.transform.position = newPosition;
            // Podemos hacer cualquier operación que necesitemos con el objeto creado, por ejemplo:
            objeto.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
