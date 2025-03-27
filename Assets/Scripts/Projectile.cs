using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 20f;

    private float destroyTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        destroyTimer = destroyTimer + Time.deltaTime;
        if (destroyTimer >= 3.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if object comes into contact with a trigger, check how the object is tagged to determine the outcome
        if (other.gameObject.CompareTag("Sardeen"))
        {
            Destroy(gameObject);
        }
    }
}
