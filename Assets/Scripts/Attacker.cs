using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour
{
    public float Health;

    public float SecondsBetweenAppearances;

    private float currentSpeed;

    private GameObject currentTarget;

    private Animator myAnimator;

	// Use this for initialization
	void Start ()
    {
        myAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (currentTarget == null)
        {
            myAnimator.SetBool("IsAttacking", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(name + " was hit by " + collision.name);
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    // called from animator
    public void StrikeCurrentTarget(float damage)
    {
        if (currentTarget == null)
        {
            return;
        }

        var defenderHealthComponent = currentTarget.GetComponent<Health>();
        if (defenderHealthComponent == null)
        {
            return;
        }

        defenderHealthComponent.TakeDamage(damage);
    }

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
