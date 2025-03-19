using UnityEngine;

public class Fishy : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            rb.AddRelativeForce(Vector3.right * speed);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            rb.AddRelativeForce(Vector3.left * speed);
        }
        else if (Input.GetAxisRaw("Vertical") == 1)
        {
            rb.AddRelativeForce(Vector3.up * speed);
        }
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            rb.AddRelativeForce(Vector3.down * speed);
        }
    }
}
