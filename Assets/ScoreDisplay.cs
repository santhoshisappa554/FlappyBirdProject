using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public BirdMovement birdMovement;
    public Text Scoredisplay;
    // Start is called before the first frame update
    void Start()
    {
        birdMovement = GameObject.Find("Bird").GetComponent<BirdMovement>();
        Scoredisplay.text = "Score:" + birdMovement.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
