using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCheck : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update

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
    }
}
