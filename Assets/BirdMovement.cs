using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rb;//RigidBody of Bird
    public float playSpeed;//Speed of the bird to Fly
    public ObstacleSpawn gameControl;
    public float Score = 0;//Initializing Score
    public RepeatMovement bg;
    public RepeatMovement ground;
    public Text ScoreText;
    AudioSource flyAudio;//Initializing the fly audio
    AudioManager manager;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        gameControl = FindObjectOfType<ObstacleSpawn>();
        bg = GameObject.Find("BackGround").GetComponent<RepeatMovement>();
        ground = GameObject.Find("Ground").GetComponent<RepeatMovement>();
        rb = GetComponent<Rigidbody2D>();
        flyAudio = GetComponent<AudioSource>();
        manager = GameObject.Find("AudioManager").GetComponent<AudioManager>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//Bird movement to fly
        {
            rb.velocity = new Vector2(0, playSpeed);
            flyAudio.Play();

            anim.SetTrigger("Flap");
          
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//Collision with the ground and Obstacles
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
            gameControl.CancelInvoke("Spawn");
            bg.xoffset = 0.0f;
            ground.xoffset = 0.0f;
            SceneManager.LoadScene(1);
            manager.PlayAudio();
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//To Update score when Bird passes through the Obstacles
    {
        if (collision.gameObject.CompareTag("Invisible"))
        {
            Score = Score + 1;
            ScoreText.text = "Score:" + Score;
        }
    }
   
}
