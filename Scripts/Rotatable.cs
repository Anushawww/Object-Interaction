using UnityEngine;

public class Rotatable : MonoBehaviour
{
    private Vector3 lastMousePosition;
    public float rotationSpeed = 5.0f;

    void OnMouseDown()
    {
        // Capture the initial mouse position when the mouse is clicked
        lastMousePosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        // Check if the Shift key is being held down
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Debug.Log("");

            // Calculate the mouse movement delta
            Vector3 delta = Input.mousePosition - lastMousePosition;

            // Update the last mouse position
            lastMousePosition = Input.mousePosition;

            // Calculate rotation around the Y-axis (horizontal mouse movement)
            float rotationY = delta.x * rotationSpeed * Time.deltaTime;

            // Calculate rotation around the X-axis (vertical mouse movement)
            float rotationX = -delta.y * rotationSpeed * Time.deltaTime;

            // Apply the rotation to the object
            transform.Rotate(Vector3.up, rotationY, Space.World);
            transform.Rotate(Vector3.right, rotationX, Space.World);
        }
        else
        {
            Debug.Log("");
        }
    }
}
