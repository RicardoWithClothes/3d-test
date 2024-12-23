using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menuUI; // Reference to the Menu UI Canvas
    public CameraController cameraController; // Reference to the CameraController script
    public PlayerMovementAdvanced playerMovement; // Reference to the player movement script
    public Rigidbody playerRigidbody;

    private bool isMenuActive = false;

    void Update()
    {
        // Toggle the menu when pressing the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isMenuActive)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        isMenuActive = true;
        menuUI.SetActive(true); // Show the menu UI

        // Disable player controls
        cameraController.enabled = false;
        playerMovement.enabled = false;

        playerRigidbody.isKinematic = true;

        // Show and unlock the cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Pause the game if needed
        Time.timeScale = 0f; // Optional: This will pause the game
    }

    void ResumeGame()
    {
        isMenuActive = false;
        menuUI.SetActive(false); // Hide the menu UI

        // Enable player controls
        cameraController.enabled = true;
        playerMovement.enabled = true;

        playerRigidbody.isKinematic = false;

        // Hide and lock the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Resume the game if needed
        Time.timeScale = 1f; // Optional: This will resume the game
    }
}
