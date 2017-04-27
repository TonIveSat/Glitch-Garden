using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ProjectileToBeShot;

    public GameObject Gun;

    private GameObject ProjectileParent;

    // Use this for initialization
    void Start ()
    {
        //gun = gameObject.get
        ProjectileParent = GameObject.Find("Projectiles");
        if (ProjectileParent == null)
        {
            ProjectileParent = new GameObject("Projectiles");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Fire()
    {
        var newProjectile = Instantiate(ProjectileToBeShot, ProjectileParent.transform) as GameObject;
        newProjectile.transform.position = Gun.transform.position;
    }
}
