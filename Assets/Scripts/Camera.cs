using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;  // The player¡¯s transform
    public float smoothing = 5f;  // Smoothness of camera follow

    private Vector3 offset;  // The initial offset between the camera and player

    void Start()
    {
        // Initialize the camera offset from the player position
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Smoothly follow the player while keeping the initial offset
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
