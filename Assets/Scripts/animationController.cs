using UnityEngine;

public class animationController : MonoBehaviour
{
    public Vector3 finalPosition;
    public float animationDuration;

    private float elapsedTime = 0f;
    private Vector3 startPosition;
    private bool isAnimating = false;

    private void Start()
    {
        startPosition = transform.position;
        isAnimating = true;
    }

    private void Update()
    {
        if (isAnimating)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / animationDuration);
            transform.position = Vector3.Lerp(startPosition, finalPosition, t);

            if (t >= 1f)
            {
                transform.position = finalPosition;
                isAnimating = false;
            }
        }
    }
}


