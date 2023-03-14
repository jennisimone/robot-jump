using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator animator = other.gameObject.GetComponent<Animator>();
            if (other.relativeVelocity.y <= 0)
            {
                Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    animator.SetBool("jump", true);
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                    StartCoroutine(resetJump(animator));
                }
            }
        }
    }

    private IEnumerator resetJump(Animator animator)
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("jump", false);
    }
}
