using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour
{
    private float currentSpeed;

    private GameObject currentTarget;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + " triggered by OnTriggerEnter2D");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    // called from animator
    public void StrikeCurrentTarget(float damage)
    {
        Debug.Log(name + " strikes with " + damage + " damage");
    }

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
