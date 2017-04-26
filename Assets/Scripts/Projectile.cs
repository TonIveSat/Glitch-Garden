using UnityEngine;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(name + " hit " + collision.gameObject.name);
         
        var attacker = collision.gameObject.GetComponent<Attacker>();
        var health = collision.gameObject.GetComponent<Health>();
        if (attacker && health)
        {
            health.TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
