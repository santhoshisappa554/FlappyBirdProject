using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    GameObject Obstacle1;
    public float ObstacleSpeed;//Speed of the Obstacle to move left
    Rigidbody2D Rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.velocity = new Vector2(-ObstacleSpeed, 0);//Moving the Obstacle towards left
        if (transform.position.x <= -9.0f)
        {
            Destroy(this.gameObject);
            
            
           
        }
    }
}
