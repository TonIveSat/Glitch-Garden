﻿using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed;

    public float Damage;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
