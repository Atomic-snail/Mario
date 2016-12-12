using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

    playerMovement PlayerMovement;

    // Use this for initialization
    void Start () {
        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();
        Destroy(this.gameObject, .3f);
        PlayerMovement.score++;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
