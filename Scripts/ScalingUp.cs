using UnityEngine;

public class ScalingUp : MonoBehaviour
{
    public float scaleFactor = 1.1f; // Factor by which to scale up
    public float maxScale = 5.0f;    // Maximum scale limit (optional)

    void Update()
    {
        // Example: Increase scale when pressing the 'S' key
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 newScale = transform.localScale * scaleFactor;

            // Optionally, limit the maximum scale
            if (newScale.magnitude <= maxScale)
            {
                transform.localScale = newScale;
            }
        }
    }
}
