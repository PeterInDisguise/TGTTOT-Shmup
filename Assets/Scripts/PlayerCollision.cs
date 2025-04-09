using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField]
    private bool isPlayerColliding = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isPlayerColliding && collision.gameObject.CompareTag("Enemy"))
        { 
            isPlayerColliding=true;
            StartCoroutine(DestroyAfterCollision(2f));
        }
    }

    IEnumerator DestroyAfterCollision(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }



}
