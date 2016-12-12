using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

    playerMovement PlayerMovement;
    public AudioClip coinSound;


    sound Sound;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();
        Sound.PlaySoundOnce(coinSound);
        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();
        Destroy(this.gameObject, .3f);
        PlayerMovement.score++;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
