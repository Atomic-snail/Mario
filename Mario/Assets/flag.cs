using UnityEngine;
using System.Collections;

public class flag : MonoBehaviour {

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
        if(otherObject.gameObject.tag == "mario")
        {
            int score = Mathf.RoundToInt(otherObject.gameObject.transform.position.y)*20;
            PlayerMovement.GameActive = false;
            PlayerMovement.score += score;
            Vector3 pos = otherObject.transform.position;
            pos.y = 1;
            otherObject.transform.position = Vector3.Lerp(otherObject.transform.position, pos, .75f);
        }
    }
}
