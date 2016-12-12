using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject mario;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(mario.transform.position.x>=this.transform.position.x)
        {
            Vector3 pos = transform.position;
            pos.x = mario.transform.position.x;
            transform.position = pos;
        }
    }

}
