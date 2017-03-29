using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(-1, 1.5f)]
    public float WalkSpeed;

	// Use this for initialization
	void Start ()
    {
        var rigidBodyComponent = gameObject.AddComponent<Rigidbody2D>();
        rigidBodyComponent.isKinematic = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * WalkSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + " triggered by OnTriggerEnter2D");
    }
}
