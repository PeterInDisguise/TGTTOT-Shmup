using UnityEngine;

public class Eel : MonoBehaviour
{
    
    

    [SerializeField] private Transform spawner;
    [SerializeField] private Transform spawner1;
    [SerializeField] private Transform spawner2;
    



    [SerializeField] private GameObject Sardeen;
    [SerializeField] private GameObject MantaRay;
    [SerializeField] private GameObject PufferFish;

    [SerializeField] private int wave = 0;
    private bool canSpawn = true;
    //health of the eel 
    [SerializeField] private float eelHealth = 80f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (eelHealth <= 0)
        {
            Debug.Log("Fuck Tesla");
            Destroy(gameObject);
        }

        if (eelHealth == 70)
        {
            wave = 1;
            Spawn();
        }
        else if (eelHealth == 69)
        {
            canSpawn = true;
        }
        else if (eelHealth == 45)
        {
            wave = 2;
        }
        else if (eelHealth == 44)
        {
            canSpawn = true;
        }
        else if (eelHealth == 20)
        {
            wave = 3;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            eelHealth--;
        }
    }

    private void Spawn()
    {
        if (wave == 1 && canSpawn)
        {
            Instantiate(MantaRay, spawner.position, spawner.rotation);
            Instantiate(PufferFish, spawner1.position, spawner1.rotation);
            Instantiate(Sardeen, spawner2.position, spawner2.rotation);
            canSpawn = false;
        }
        else if (wave == 2 && canSpawn)
        {
            Instantiate(MantaRay, spawner.position, spawner.rotation);
            Instantiate(PufferFish, spawner1.position, spawner1.rotation);
            Instantiate(PufferFish, spawner2.position, spawner2.rotation);
            canSpawn = false;
        }
        else if (wave == 3 && canSpawn)
        {
            Instantiate(PufferFish, spawner.position, spawner.rotation);
            Instantiate(PufferFish, spawner1.position, spawner1.rotation);
            Instantiate(PufferFish, spawner2.position, spawner2.rotation);
            canSpawn = false;
        }
    }
}
