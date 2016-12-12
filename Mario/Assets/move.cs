using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float speed = 1.0f;
    public float jumpSpeed = 0.5f;
    public LayerMask groundLayer;

    private Animator marioAnimator;
    private Transform gCheck;
    private float scaleX = 1.0f;
    private float scaleY = 1.0f;
    public Rigidbody2D RB;
    void Start()
    {
        gCheck = transform.FindChild("GCheck");

    }

    void FixedUpdate()
    {
        float mSpeed = Input.GetAxis("Horizontal");
        bool isTouched = false;

        if (Input.GetKey(KeyCode.Space))
        {

            if (isTouched)
            {
                RB.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
                isTouched = false;
            }
        }


        if (mSpeed > 0){
            transform.localScale = new Vector2(scaleX, scaleY);
        }
		else if (mSpeed < 0){
            transform.localScale = new Vector2(-scaleX, scaleY);
        }

        RB.velocity = new Vector2(mSpeed * speed, RB.velocity.y);
    }
}
