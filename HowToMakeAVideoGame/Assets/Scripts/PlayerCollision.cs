using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    public PlayerMovement movement; // A reference to our PlayerMovement Script

    // This functions runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter (Collision collisionInfo) {

        // We check if the object collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false; // Disable the players movment.
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }

}
