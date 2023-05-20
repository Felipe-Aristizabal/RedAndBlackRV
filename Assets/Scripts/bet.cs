using UnityEngine;


public class bet : MonoBehaviour
{
	private RotateAround refRotateAround;
    GameObject[] objectsToDestroywhite;
    GameObject[] objectsToDestroygreen;
    GameObject[] objectsToDestroyred;

	void Start() {
		refRotateAround = GameObject.Find ("RotatorRoullete").GetComponent<RotateAround> ();
	}
		
    void Update(){
        objectsToDestroywhite = GameObject.FindGameObjectsWithTag("WhiteChip");
        objectsToDestroyred = GameObject.FindGameObjectsWithTag("RedChip");
        objectsToDestroygreen = GameObject.FindGameObjectsWithTag("GreenChip");
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
    }

	public void OnTriggerEnter(Collider other) {
		refRotateAround.stop = true;
	}
}
