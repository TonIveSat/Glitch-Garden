using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HitPoints;

    private bool isDefender;

    private bool isStone;
    
    // Use this for initialization
    void Start ()
    {
        isDefender = GetComponent<Defender>() != null;
        isStone = GetComponent<Stone>() != null;
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
        else if (isStone)
        {
            GetComponent<Animator>().SetTrigger("Under Attack Trigger");
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
