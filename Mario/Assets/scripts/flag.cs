using UnityEngine;
using System.Collections;

public class flag : MonoBehaviour {

    playerMovement PlayerMovement;
    sound Sound;

    public AudioClip win;
    public AudioClip win2;
    public float endTime;
    public float soundLength;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();

        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();

    }

    // Update is called once per frame
    void Update ()
    {
	if(endTime >0 && Time.time >= endTime)
        {
            Application.LoadLevel("end");
        }
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
            otherObject.transform.position = Vector3.Lerp(otherObject.transform.position, pos, 5);
            Sound.PlaySoundOnce(win);
            Sound.PlaySoundOnce(win2);
            endTime = Time.time + soundLength;
            
        }
    }
}
