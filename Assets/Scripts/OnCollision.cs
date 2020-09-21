using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public PlayerMovement movement;

        

    private void OnCollisionEnter(Collision collision)
    {
   //     Debug.Log("we hit this");
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
   
}
