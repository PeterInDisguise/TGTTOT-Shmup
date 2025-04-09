using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    public Camera mainCamera;  // The camera used in the scene (can be set in the inspector)

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;  // Default to the main camera if none is assigned
        }
    }

    void Update()
    {
        // Get the player's current position
        Vector3 playerPos = transform.position;

        // Convert the screen-space positions of the camera's boundaries into world space
        Vector3 bottomLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, Mathf.Abs(mainCamera.transform.position.z)));
        Vector3 topRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Mathf.Abs(mainCamera.transform.position.z)));

        // Debugging: Check the player's position and the boundaries
        //Debug.Log($"Player Position: {playerPos}");
        //Debug.Log($"Bounds: Bottom Left={bottomLeft}, Top Right={topRight}");

        // Clamp the player's position to be within the boundaries
        playerPos.x = Mathf.Clamp(playerPos.x, bottomLeft.x, topRight.x);
        playerPos.y = Mathf.Clamp(playerPos.y, bottomLeft.y, topRight.y);

        // Debugging: Check clamped position
        //Debug.Log($"Clamped Player Position: {playerPos}");

        // Apply the clamped position back to the player's transform
        transform.position = playerPos;
    }
}
