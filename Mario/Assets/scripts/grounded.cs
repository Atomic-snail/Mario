using UnityEngine;
using System.Collections;

public class grounded : MonoBehaviour {

    playerMovement PlayerMovement;
    sound Sound;
    public AudioClip hit;
    public AudioClip stomp;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();

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
            Sound.PlaySoundOnce(stomp);
            Destroy(otherObject.gameObject);
        }
        if(otherObject.gameObject.tag == "void")
        {
            Sound.PlaySoundOnce(hit);
            PlayerMovement.hits -= 50;
        }
        PlayerMovement.grounded = true;
    }
    

}
