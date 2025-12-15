using System;
using UnityEngine;
public class Bird : MonoBehaviour
{
    public LevelSelectionUI gameOver;
    private Rigidbody2D bird;
    public bool isEntered;
    public bool isTouch;
    public bool isClicked;
    public ScoreManager scoreManager;
    public AudioManager audioManager;
    void Awake()
    {
        bird = GetComponent<Rigidbody2D>();
        bird.gravityScale = 0f;

    }
    public float jumpForce;
    void Update()
    {
        if (bird != null)
        {
            bool jumpPressed = false;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpPressed = true;
            }

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    jumpPressed = true;
                }
            }

            if (jumpPressed)
            {
                Jump();
            }
        }
    }



    public void Jump()
    {
        bird.gravityScale = 1f;
        bird.linearVelocity = new Vector2(bird.linearVelocity.x, jumpForce);
        audioManager.PlaySFX(audioManager.jump);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            Time.timeScale = 0f;
            gameOver.GameOver();
           
            isClicked = false;
            isTouch = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Score"))
        {
            scoreManager.AddScore();
            audioManager.PlaySFX(audioManager.score);
        }

    }
}

