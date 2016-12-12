using UnityEngine;
using System.Collections;

public class edge : MonoBehaviour {

    playerMovement PlayerMovement;

    // Use this for initialization
    void Start()
    {
        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();
    }


    // Update is called once per frame
    void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.tag == "mario")
        {
            PlayerMovement.moveleft = false;
        }
    }
    void OnTriggerExit2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.tag == "mario")
        {
            PlayerMovement.moveleft = true;
        }
    }
}
