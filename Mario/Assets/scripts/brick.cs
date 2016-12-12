using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

    public AudioClip BrickBreak;

    sound Sound;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();

    }

    // Update is called once per frame
    void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.tag == "mario")
        {
            if (otherObject.gameObject.GetComponent<playerMovement>().hits >= 2)
            {
                Destroy(this.gameObject);
                Sound.PlaySoundOnce(BrickBreak);
            }
        }
    }
}
