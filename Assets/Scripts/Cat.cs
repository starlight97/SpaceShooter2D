using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float jumpSpeed;
    private Animator anim;
    private Rigidbody2D rbody2d;

    [SerializeField]
    private float velocity;
    void Start()
    {
        this.anim = this.GetComponent<Animator>();
        this.rbody2d = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        this.velocity = this.rbody2d.velocity.y;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.Jump();
        }
    }

    private void Jump()
    {
        this.anim.SetTrigger("JumpTrigger");
        // Walk -> Jump
        this.rbody2d.AddForce(Vector3.up * jumpSpeed);
    }
}
