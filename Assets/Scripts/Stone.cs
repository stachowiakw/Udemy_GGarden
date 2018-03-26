﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        Attacker attacker = collision.gameObject.GetComponent<Attacker>();

        if (attacker)
        {
            animator.SetTrigger("underAttack trigger");
        }
    }
}
