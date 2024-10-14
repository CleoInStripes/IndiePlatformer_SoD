using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    private Animator anim;

    private Rigidbody2D _rigidbody;
    void Start()
    {
        anim = GetComponent<Animator>();
        
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            anim.SetBool("OnGround", true);
        }
        else
        {
            anim.SetBool("OnGround", false);
        }
    }
}