using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(-1, 1.5f)]
    public float WalkSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * WalkSpeed * Time.deltaTime);
	}
}
