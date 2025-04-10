using Unity.VisualScripting;
using UnityEngine;

public class Manta : EnemyBase
{
    private Fishy fish; //this line is not necessary, but I liked it so much that it can stay <3
    private Rigidbody rb;
    [SerializeField] private Transform playerPosition;

    [SerializeField] private float shootTimer = 0f;
    [SerializeField] private GameObject electricball;
    [SerializeField] private Transform electricPoint;

    [SerializeField] private float mantaSpeed = 20f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.linearVelocity = -transform.right * mantaSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, playerPosition.position.y, playerPosition.position.z);
        shootTimer = shootTimer + Time.deltaTime;

        if (shootTimer >= 7f )
        {
            IBeFiringMyLaser();
        }
    }

    public override void Activate()
    {
        
    }

    private void IBeFiringMyLaser()
    {
        GameObject ball = Instantiate(electricball, electricPoint.position, electricPoint.rotation);
        shootTimer = 2;
    }
        
}
