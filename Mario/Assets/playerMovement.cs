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
    



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(GameActive)
            movement();
        if(hits<= 0)
        {
            Destroy(this.gameObject);
        }
	}

    void movement()
    {
        if(Input.GetKey("a"))
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
        }
        if(Input.GetKey("w") && Time.time<jumpTime)
        {
            RB.AddForce(Vector2.up * jumpBoost);
        }
    }
}
