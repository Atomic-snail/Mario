using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public float speed;
    public float jump;
    public float jumpBoost;
    public float jumpLength;
    public float jumpTime;
    public Rigidbody2D RB;
    public bool grounded;
    public int score;
    public int hits;
    public bool GameActive;
    public bool moveleft;
    public AudioClip mushroom;
    public AudioClip jumpSound;



    sound Sound;

    // Use this for initialization
    void Start()
    {
        Sound = GameObject.FindGameObjectWithTag("sound").GetComponent<sound>();

    }

    // Update is called once per frame
    void Update ()
    {
        if(GameActive)
            movement();
        if(hits<= 0)
        {
            Destroy(this.gameObject);
            Application.LoadLevel("end");
        }
        else if(hits<=1)
        {
            Vector3 scale = transform.localScale;
            scale.x = -1.441858f;
            scale.y = -1.960926f;
            scale.z = 1.960926f;
            transform.localScale = scale;
        }
	}

    void movement()
    {
        if(Input.GetKey("a") && moveleft)
        {
            RB.AddForce(Vector2.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            RB.AddForce(Vector2.right * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown("w") && grounded)
        {
            RB.AddForce(Vector2.up * jump);
            jumpTime = jumpLength + Time.time;
            grounded = false;
            Sound.PlaySoundOnce(jumpSound);
        }
        if(Input.GetKey("w") && Time.time<jumpTime)
        {
            RB.AddForce(Vector2.up * jumpBoost);
        }
    }
    public void grow()
    {
        hits++;
        Vector3 scale = transform.localScale;
        scale.y *= 2;
        transform.localScale = scale;
        Sound.PlaySoundOnce(mushroom);
    }
    
}
