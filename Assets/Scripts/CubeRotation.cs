using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 30f;
    void Update()
    {
        // Rotate the cube around the y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}