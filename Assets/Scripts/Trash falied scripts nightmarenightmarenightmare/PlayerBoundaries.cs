using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    public Camera mainCamera;  

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;  
        }
    }

    void Update()
    {
        
        Vector3 playerPos = transform.position;

        
        Vector3 bottomLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, Mathf.Abs(mainCamera.transform.position.z)));
        Vector3 topRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Mathf.Abs(mainCamera.transform.position.z)));

        
        

        
        playerPos.x = Mathf.Clamp(playerPos.x, bottomLeft.x, topRight.x);
        playerPos.y = Mathf.Clamp(playerPos.y, bottomLeft.y, topRight.y);

        
        

        
        transform.position = playerPos;
    }
}
