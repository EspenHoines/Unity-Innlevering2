using UnityEngine;
using System.Collections;

public class goombaAI : MonoBehaviour {

	public float velocity = 1f;

	public Transform checkWallA;
	public Transform checkWallB;
	public LayerMask detector;

	public bool colliding;

	public Transform stompedDead;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2 (velocity, GetComponent<Rigidbody2D>().velocity.y);

		colliding = Physics2D.Linecast (checkWallA.position, checkWallB.position, detector);
	
		if (colliding) 
		{
			transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
			velocity/= -1;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			float height = col.contacts[0].point.y + stompedDead.position.y;

			if(height > 1)
			{
				Death();
				col.rigidbody.AddForce(new Vector2(0, 300));
			}
		}


	}

	void Death() 
	{
		anim.SetBool ("stompedv2", true);
		Destroy (this.gameObject, 0.5f);
		gameObject.tag = "Safe";

	}
}
