using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public GameManager gameManager;
    private float moveX;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GameOver")
        {
            gameManager.SetHighScore();
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
