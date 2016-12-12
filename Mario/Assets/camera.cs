using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject Camera;
    public GameObject mario;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos;
        pos = Camera.transform.position;
        pos.x = mario.transform.position.x;
        Camera.transform.position = pos;
    }
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.tag=="mario")
        {
            Vector3 pos;
            pos = Camera.transform.position;
            pos.x = mario.transform.position.x;
            Camera.transform.position = pos;
        }
    }
}
