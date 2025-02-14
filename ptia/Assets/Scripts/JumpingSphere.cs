using UnityEngine;

public class JumpingSphere : Sphere
{
    private float jumpForce = 75f;
    // ENCAPSULATION
    protected float JumpForce { 
        get { return jumpForce; }
        set {
            if (value < 10) {
                Debug.LogError("Jump force must be at least 10");
            } else {
                jumpForce = value;
            }
        }
    }

    // POLYMORPHISM
    protected override void Special()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // INHERITANCE
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}
