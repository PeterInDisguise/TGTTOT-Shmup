using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishy : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    private Rigidbody rb;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletSpawnpoint;

    private bool canShoot = true;
    [SerializeField] private float shootTimer = 0f;
    [SerializeField] private int gunType = 0;
    private bool isRapidFiring = false;

    [SerializeField] private int score = 0;
    [SerializeField] private float maxhealth = 2;


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
        if (Input.GetKey(KeyCode.Space) && canShoot == true && gunType == 0)
        {
            GameObject Bullet = Instantiate(BulletPrefab, BulletSpawnpoint.position, BulletSpawnpoint.rotation);
            canShoot = false;
        }
        else if (Input.GetKey(KeyCode.Space) && canShoot == true && gunType == 1)
        {
            isRapidFiring = true;
        }
        else
        {
            isRapidFiring = false;
        }

        if (isRapidFiring == true)
        {
            GameObject Bullet = Instantiate(BulletPrefab, BulletSpawnpoint.position, BulletSpawnpoint.rotation);
            canShoot = false;
        }

        if (canShoot == false && gunType == 0)
        {
            shootTimer = shootTimer + Time.deltaTime;
            if (shootTimer >= 1f)
            {
                shootTimer = 0;
                canShoot = true;
            }
        }
        else if (canShoot == false && gunType == 1)
        {
            shootTimer = shootTimer + Time.deltaTime;
            if (shootTimer >= 0.1f)
            {
                shootTimer = 0;
                canShoot = true;
            }
        }

        //if player health is 0 or below 0, destroy the player object
        if (maxhealth <= 0)
        {
            Debug.Log("you died!");
            SceneManager.LoadScene("Game Over screen");
        }
    }

    private void FixedUpdate()
    {
        ////make the player move with Input.GetAxisRaw
        //if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    rb.AddRelativeForce(Vector3.right * speed);
        //}
        //else if (Input.GetAxisRaw("Horizontal") == -1)
        //{
        //    rb.AddRelativeForce(Vector3.left * speed);
        //}
        //else if (Input.GetAxisRaw("Vertical") == 1)
        //{
        //    rb.AddRelativeForce(Vector3.up * speed);
        //}
        //else if (Input.GetAxisRaw("Vertical") == -1)
        //{
        //    rb.AddRelativeForce(Vector3.down * speed);
        //}
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            score++;
        }
        if (collision.gameObject.CompareTag("Sardeen"))
        {
            maxhealth--;
        }
    }
}
