using UnityEngine;

public class Eel : MonoBehaviour
{
    private bool inRange = false;
    [SerializeField] private float spawnTimer = 0f;

    [SerializeField] private Transform spawner;
    [SerializeField] private Transform spawner1;
    [SerializeField] private Transform spawner2;



    [SerializeField] private GameObject Sardeen;
    [SerializeField] private GameObject MantaRay;
    [SerializeField] private GameObject PufferFish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            spawnTimer = spawnTimer + Time.deltaTime;
            if (spawnTimer >= 10f)
            {
                EnemySpawn();
            }
        }
        
    }

    private void EnemySpawn()
    {

    }
}
