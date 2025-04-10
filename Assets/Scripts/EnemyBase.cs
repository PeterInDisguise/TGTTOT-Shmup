using UnityEngine;


public abstract class EnemyBase : MonoBehaviour
{
    protected int scoreToAdd = 10;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    public virtual void Activate()
    {

    }
}
