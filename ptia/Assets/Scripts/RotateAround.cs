using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] Transform centerPoint;
    [SerializeField] float rotateSpeed = 10f;

    void FixedUpdate()
    {
        transform.RotateAround(centerPoint.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
