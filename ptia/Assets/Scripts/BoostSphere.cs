using UnityEngine;

public class BoostSphere : Sphere
{
    private float speedMultiplier = 5f;
    public float SpeedMultiplier {
        get { return speedMultiplier; }
        set { 
            if (value < 1.5) {
                Debug.LogError("Speed multiplier must be at least 1.5!");
            } else {
                speedMultiplier = value;
            }
        }
    }

    protected override void Special()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            MoveSpeed *= SpeedMultiplier;
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            MoveSpeed /= SpeedMultiplier;
        }
    }
}
