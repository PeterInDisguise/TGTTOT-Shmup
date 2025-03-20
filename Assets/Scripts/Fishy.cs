using UnityEngine;

public class Fishy : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Rigidbody rb;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletSpawnpoint;

    private bool canShoot = true;
    [SerializeField] private float shootTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //make the player move with Input.GetAxisRaw
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

        //make the player shoot using the spacebar (if they can shoot already after the last shot) 
        if (Input.GetKeyDown(KeyCode.Space) && canShoot == true)
        {
            GameObject Bullet = Instantiate(BulletPrefab, BulletSpawnpoint.position, BulletSpawnpoint.rotation);
            canShoot = false;
        }

        if (canShoot == false)
        {
            shootTimer = shootTimer + Time.deltaTime;
            if (shootTimer >= 1f)
            {
                shootTimer = 0;
                canShoot = true;
            }
        }

    }
}
