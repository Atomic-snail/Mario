using UnityEngine;
using System.Collections;

public class questionMarkblock : MonoBehaviour {

    public GameObject toSpawn;
    public GameObject spawnPos;
    public GameObject blankBlock;
    public int multiplier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(multiplier <= 0)
        {
            Instantiate(blankBlock, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.tag == "mario")
        {
            Instantiate(toSpawn, spawnPos.transform.position, spawnPos.transform.rotation);
            multiplier--;
        }
    }
}
