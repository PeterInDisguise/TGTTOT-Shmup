using UnityEngine;
using UnityEngine.WSA;

public abstract class enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected!");
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    public virtual void Activate()
    {

    }
}
