using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Player_Movement movement;// A Reference to PlayerMovement Script

    private void OnCollisionEnter(Collision collisioninfo)
    {
        //we check if we collided with the tag called "Obstacle"
        if(collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;//Disable Player Movement or write   GetComponent<Player_Movement>().enabled = false;
            Debug.Log("We Hit " + collisioninfo.collider.tag);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
