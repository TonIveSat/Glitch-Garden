using System;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ProjectileToBeShot;

    public GameObject Gun;

    private GameObject ProjectileParent;

    private Animator animator;

    private Spawner spawner;

    // Use this for initialization
    void Start ()
    {
        //gun = gameObject.get
        ProjectileParent = GameObject.Find("Projectiles");
        if (ProjectileParent == null)
        {
            ProjectileParent = new GameObject("Projectiles");
        }
        animator = GetComponent<Animator>();

        foreach (var spawnerLane in FindObjectsOfType<Spawner>()) 
        {
            if (spawnerLane.transform.position.y == transform.position.y)
            {
                spawner = spawnerLane;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("IsAttacking", IsAttackerAheadInLane());
	}

    private bool IsAttackerAheadInLane()
    {
        bool attackerAheadFound = false;
        foreach (var attacker in spawner.GetComponentsInChildren<Attacker>())
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        return false;
    }

    private void Fire()
    {
        var newProjectile = Instantiate(ProjectileToBeShot, ProjectileParent.transform) as GameObject;
        newProjectile.transform.position = Gun.transform.position;
    }
}
