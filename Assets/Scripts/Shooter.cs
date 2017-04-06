using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ProjectileToBeShot;

    public GameObject ProjectileParent;

    public GameObject Gun;

    private void Fire()
    {
        var newProjectile = Instantiate(ProjectileToBeShot, ProjectileParent.transform) as GameObject;
        newProjectile.transform.position = Gun.transform.position;
    }

    // Use this for initialization
    void Start ()
    {
		//gun = gameObject.get½1
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
