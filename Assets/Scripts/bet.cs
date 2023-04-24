using UnityEngine;

public class bet : MonoBehaviour
{
	GameObject[] objectsToDestroy;

	void Update(){
		objectsToDestroy = GameObject.FindGameObjectsWithTag("Waste");
	}

    void OnCollisionEnter(Collision col)
    {
            foreach (GameObject objectToDestroy in objectsToDestroy)
            {
                Destroy(objectToDestroy);
            }
    }
}

