using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameManager game;
    Rigidbody2D rb;
    AudioSource jumpSource;
    public float jumpSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,9);
        jumpSource = GetComponent<AudioSource>();
        Pipe.speed = 0;
    }

    // JUMP
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 5f);

        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            game.startGame();
            Pipe.speed = 4;
            rb.simulated = true;
            rb.velocity = new Vector2(0, jumpSpeed);
            jumpSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Pipe.speed = 0; 
        game.EndGame();

    }

    void OnTriggerExit2D(Collider2D other)
    {
        game.score++;        
    }
}