using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public PlayerMovement movement;

        

    private void OnCollisionEnter(Collision collision)
    {
   //     Debug.Log("we hit this");
        if (collision.collider.tag == "Obstacle")
        {
           Debug.Log("we hit this");
            movement.enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
