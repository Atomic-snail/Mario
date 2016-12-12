using UnityEngine;
using System.Collections;

public class grounded : MonoBehaviour {

    playerMovement PlayerMovement;

	// Use this for initialization
	void Start ()
    {
        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();
	}

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.tag == "goomba")
        {

            Destroy(otherObject.gameObject);
        }
        if(otherObject.gameObject.tag == "void")
        {
            PlayerMovement.hits--;
        }
        PlayerMovement.grounded = true;
    }
    void OnTriggerExit2D()
    {
        PlayerMovement.grounded = false;
    }

}
