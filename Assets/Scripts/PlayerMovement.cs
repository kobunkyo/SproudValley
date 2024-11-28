using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D rb;

    Animator animator;

    [SerializeField]
    float moveSpeed = 5f;

    float moveH, moveY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        Debug.Log($"moveH{moveH}  moveY{moveY}");

        rb.velocity = new Vector2 (moveH, moveY).normalized * moveSpeed;

        Animation();
    }

    private void Animation()
    {
        if (moveH > 0 || (moveH > 0 && (moveY < 0 || moveY > 0)))
        {
            animator.SetBool("isMove", true);
            animator.SetBool("isRight", true);
            animator.SetBool("isBackward", false);
            animator.SetBool("isForward", false);
            animator.SetBool("isLeft", false);
        }
        else if(moveH < 0 || (moveH < 0 && (moveY < 0 || moveY > 0)))
        {
            animator.SetBool("isMove", true);
            animator.SetBool("isLeft", true);
            animator.SetBool("isBackward", false);
            animator.SetBool("isForward", false);
            animator.SetBool("isRight", false);
        }
        else if(moveY > 0 )
        {
            animator.SetBool("isMove", true);
            animator.SetBool("isBackward", true);
            animator.SetBool("isForward", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isRight", false);
        }
        else if(moveY < 0)
        {
            animator.SetBool("isMove", true);
            animator.SetBool("isForward", true);
            animator.SetBool("isBackward", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isRight", false);
        }
        else
        {
            animator.SetBool("isMove", false);
            animator.SetBool("isBackward", false);
            animator.SetBool("isForward", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isRight", false);
        }
    }
}
