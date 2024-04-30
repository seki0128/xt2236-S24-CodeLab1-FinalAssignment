using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;
using Image = UnityEngine.UI.Image;

public class MouseController : MonoBehaviour
{
    public float sensitivity = 0.5f; // Mouse sensitivity
    //public Transform playerBody; // Reference to the player's body (optional)

    float mouseX, mouseY;

    private Ray ray;
    private RaycastHit hit;

    private Image cursorImage;

    void Start()
    {
        cursorImage = GameObject.Find("Cursor").GetComponent<Image>();
        Cursor.lockState = CursorLockMode.Locked;         // Hide and lock cursor to center of screen
    }

    void Update()
    {
        // === FOR MOVEMENT: === //

            mouseX += Input.GetAxis("Mouse X") * sensitivity;   // Get mouse movement
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
            mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Clamp vertical rotation

            transform.localRotation = Quaternion.Euler(mouseY, mouseX, 0f); // Rotate the camera vertically

            //  Rotate the player horizontally (optional)
            //  if(playerBody != null)
            //  playerBody.Rotate(Vector3.up * mouseX);

        // === FOR CLICK: === //
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);         // Create a ray from the mouse position
            cursorImage.color = Color.white;
            
            if (Physics.Raycast(ray, out hit))
            {
                cursorImage.color = Color.red;

                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.collider.gameObject);
                    GameManager.instance.audioManager.sfx.PlayOneShot(GameManager.instance.audioManager.note);
                }
            }

    }
}

