using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 5f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.right * cameraSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
