using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] obstacles;

    public int value;
    
    // Start is called before the first frame update
    void Start()
    {
       
            InvokeRepeating("Spawn", 2.0f, 3.0f);//Spawning the obstacles at different positions and lengths
        
        
    }

    public void Spawn()
    {
        value = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[value], transform.position, Quaternion.identity);//instantiate the clone
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
