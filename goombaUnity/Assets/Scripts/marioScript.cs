using UnityEngine;
using System.Collections;

public class marioScript : MonoBehaviour {

	public float speedForce= 20f;
	public Vector2 jumpVector;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-speedForce,GetComponent<Rigidbody2D>().velocity.y);
		} else if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (speedForce,GetComponent<Rigidbody2D>().velocity.y);
		}

		else GetComponent<Rigidbody2D>().velocity = new Vector2 (0,GetComponent<Rigidbody2D>().velocity.y);
		//Tried doing jump, but he keeps floating
		/*if (Input.GetKeyDown (KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().AddForce(jumpVector, ForceMode2D.Force);
		}*/
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
				Death();
		}
		
		
	}
	void Death() 
	{
		Destroy (this.gameObject, 0.5f);
		
	}
}
