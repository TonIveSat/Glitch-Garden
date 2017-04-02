﻿using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour
{
    private Animator animator;

    private Attacker attacker;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update ()
    {
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.GetComponent<Defender>() == null)
        {
            return;
        }

        if (obj.GetComponent<Stone>() != null)
        {
            animator.SetTrigger("Jump trigger");
        }
        else
        {
            animator.SetBool("IsAttacking", true);
            attacker.Attack(obj);
        }

    }
}
