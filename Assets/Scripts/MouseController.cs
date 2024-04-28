using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
        public float sensitivity = 2.0f; // Mouse sensitivity
        public Transform playerBody; // Reference to the player's body (optional)

        float mouseX, mouseY;

        void Start()
        {
            // Hide and lock cursor to center of screen
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            // Get mouse movement
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
            mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Clamp vertical rotation

            // Rotate the camera vertically
            transform.localRotation = Quaternion.Euler(mouseY, 0f, 0f);
        
            // Rotate the player horizontally (optional)
            if(playerBody != null)
                playerBody.Rotate(Vector3.up * mouseX);
        }
}
