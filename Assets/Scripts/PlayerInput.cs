using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    [SerializeField] private float xRange = 1.2f;   //
    [SerializeField] private float yRange = 0.8f;   //
    [SerializeField] private float smoothing = 5f;  //

    void OnTriggerEnter(Collider collider)
    {
        print("triggerEnter");

        // Find out what hit the player
        GameObject collidedWith = collider.gameObject;

        // If it's an asteroid destroy it and remove player life
        if (collidedWith.CompareTag ("asteroid"))
        {
            print("collided with asteroid");
            Destroy(collidedWith);
        }
    }
    void Update () {
		// Get the mouse postion (On 2D Screen)
        Vector3 mousePos2D = Input.mousePosition;

        Cursor.lockState = CursorLockMode.Confined; // Keep mouse confined to the game window

        float posx = Mathf.Lerp(-xRange, xRange, mousePos2D.x / Screen.width);  //
        float posY = Mathf.Lerp(-yRange, yRange, mousePos2D.y / Screen.height); //

        transform.position = Vector3.Lerp(transform.position, new Vector3(posx, posY, transform.position.z), Time.deltaTime * smoothing);   //
    }
}
