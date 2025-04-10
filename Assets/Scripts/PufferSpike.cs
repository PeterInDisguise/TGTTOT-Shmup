using UnityEngine;

public class PufferSpike : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float spikeSpeed = 150f;
    private float spikeDestroyTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * spikeSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        spikeDestroyTimer = spikeDestroyTimer + Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
