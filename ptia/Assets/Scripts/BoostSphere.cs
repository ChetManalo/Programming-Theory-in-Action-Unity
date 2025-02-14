using UnityEngine;

public class BoostSphere : Sphere
{
    private float speedMultiplier = 5f;
    // ENCAPSULATION
    protected float SpeedMultiplier {
        get { return speedMultiplier; }
        set { 
            if (value < 1.5) {
                Debug.LogError("Speed multiplier must be at least 1.5!");
            } else {
                speedMultiplier = value;
            }
        }
    }

    // POLYMORPHISM
    protected override void Special()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // INHERITANCE
            MoveSpeed *= SpeedMultiplier;
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            MoveSpeed /= SpeedMultiplier;
        }
    }
}
