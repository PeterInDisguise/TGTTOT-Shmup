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
        // Get the camera's field of view and the aspect ratio
        // Frustum boundaries calculation based on perspective camera's FOV
        float frustumHeight = 2f * Mathf.Tan(mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * Mathf.Abs(mainCamera.transform.position.z);
        float frustumWidth = frustumHeight * mainCamera.aspect;

        // Get the player's current position
        Vector3 playerPos = transform.position;

        // Define the boundaries of the screen (camera's visible area) in world space
        // Use the camera's position to calculate the world-space boundaries
        float leftBoundary = mainCamera.transform.position.x - frustumWidth / 2;
        float rightBoundary = mainCamera.transform.position.x + frustumWidth / 2;
        float bottomBoundary = mainCamera.transform.position.y - frustumHeight / 2;
        float topBoundary = mainCamera.transform.position.y + frustumHeight / 2;

        // Debugging: Check the boundaries and player's position
        Debug.Log($"Player Position: {playerPos}");
        Debug.Log($"Bounds: Left={leftBoundary}, Right={rightBoundary}, Bottom={bottomBoundary}, Top={topBoundary}");

        // Clamp the player's position on the X and Z axes
        playerPos.x = Mathf.Clamp(playerPos.x, leftBoundary, rightBoundary);
        playerPos.y = Mathf.Clamp(playerPos.y, bottomBoundary, topBoundary);

        // Debugging: Check clamped position
        Debug.Log($"Clamped Player Position: {playerPos}");

        // Apply the clamped position back to the player's transform
        transform.position = playerPos;
    }
}
