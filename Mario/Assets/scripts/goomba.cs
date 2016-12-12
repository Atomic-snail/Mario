using UnityEngine;
using System.Collections;

public class goomba : MonoBehaviour {

    public float speed;
    public Rigidbody2D RB;
    public int direction;
    playerMovement PlayerMovement;
    public AudioClip hit;
    

    sound Sound;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();

        PlayerMovement = GameObject.FindGameObjectWithTag("mario").GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update ()
    {
        RB.AddForce(Vector2.left * direction * speed * Time.deltaTime);
	}
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.tag == "mario"&&this.gameObject.tag == "goomba")
        {
            //do the kill thing
            print("ouch");
            PlayerMovement.hits--;
            Sound.PlaySoundOnce(hit);
            
        }
        if(otherObject.gameObject.tag == "mario" && this.gameObject.tag == "mushroom")
        {
            Destroy(this.gameObject);
            otherObject.gameObject.GetComponent<playerMovement>().grow();
            

        }
        Vector3 scale;
        scale= transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        direction = direction *-1;
    }
}
