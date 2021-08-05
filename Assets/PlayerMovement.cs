using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed= 3f;
    public Rigidbody2D RB;
    Vector2 movement;
    public Animator animator;
    public float leftright;
    public float updown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == -1f)
        {
            animator.SetFloat("leftright", -1f);
            animator.SetFloat("updown", 0f);
        }
        if (Input.GetAxisRaw("Horizontal") == 1f)
        {
            animator.SetFloat("leftright", 1f);
            animator.SetFloat("updown", 0f);
        }
        if (Input.GetAxisRaw("Vertical") == 1f)
        {
            animator.SetFloat("updown", 1f);
            animator.SetFloat("leftright", 0f);
        }
        if (Input.GetAxisRaw("Vertical") == -1f)
        {
            animator.SetFloat("updown", -1f);
            animator.SetFloat("leftright", 0f);
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //Movement
        RB.MovePosition(RB.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
