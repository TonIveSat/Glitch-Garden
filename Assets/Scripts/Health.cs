using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HitPoints;

    private bool isDefender;

	// Use this for initialization
	void Start ()
    {
        isDefender = GetComponent<Defender>() != null;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void TakeDamage(float damage)
    {
        HitPoints -= damage;

        if (HitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
