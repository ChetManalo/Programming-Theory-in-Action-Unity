using NUnit.Framework.Constraints;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    protected Rigidbody rb;
    private float velocityX;
    private float velocityZ;
    private float moveSpeed = 65f;
    protected float MoveSpeed {
        get { return moveSpeed; }
        set {
            if (value < 10) {
                Debug.LogError("Move speed must be at least 10!");
            } else {
                moveSpeed = value;
            }
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocityX = Random.Range(-1f, 1f);
        velocityZ = Random.Range(-1f, 1f);
    }

    void Update() {
        Move();
        Special();
    }

    private void Move() {
        rb.AddForce(new Vector3(velocityX, 0, velocityZ) * MoveSpeed * Time.deltaTime, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collidable")) {
            velocityX *= -1;
            velocityZ *= -1;
        }
    }

    protected virtual void Special(){}
}
