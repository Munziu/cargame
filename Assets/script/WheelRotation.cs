using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public float wheelRadius = 0.3f; // Example radius of the wheel in meters

    public void RotateWheel(float speed)
    {
        // Calculate the circumference of the wheel
        float wheelCircumference = 2 * Mathf.PI * wheelRadius;

        // Calculate the rotation angle based on speed and wheel circumference
        float rotationAngle = (speed / wheelCircumference) * 360;

        // Apply rotation to the wheel
        transform.Rotate(Vector3.right, rotationAngle * Time.deltaTime);

        // Debug log for checking the rotation values
        Debug.Log($"Rotating wheel with angle: {rotationAngle} based on speed: {speed}");
    }
}
