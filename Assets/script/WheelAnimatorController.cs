using UnityEngine;

public class WheelAnimatorControl : MonoBehaviour
{
    public Animator animator;
    public float rotationSpeedMultiplier = 1.0f;
    private Rigidbody carRigidbody;

    void Start()
    {
        carRigidbody = GetComponentInParent<Rigidbody>();
    }

    void Update()
    {
        // Calculate the wheel's rotation speed based on the car's velocity
        float speed = carRigidbody.velocity.magnitude;
        animator.SetFloat("RotationSpeed", speed * rotationSpeedMultiplier);
    }
}
