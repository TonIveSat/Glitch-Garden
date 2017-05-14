using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRateModifier = 1f;

    public GameObject[] Attackers;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        var maxAttackerIndex = Attackers.Length-1;
        foreach (var attacker in Attackers)
        { 
            if (Random.value < Time.deltaTime * SpawnRateModifier / attacker.GetComponent<Attacker>().SecondsBetweenAppearances)
            {
                Spawn(attacker);
            }
        }
    }

    public void Spawn(GameObject myGameobject)
    {
        var newAttacker = Instantiate(myGameobject) as GameObject;
        newAttacker.transform.parent = transform;
        newAttacker.transform.position = transform.position;
    }
}
