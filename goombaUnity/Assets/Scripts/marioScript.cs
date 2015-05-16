using UnityEngine;
using System.Collections;

public class marioScript : MonoBehaviour {

	public float speedForce= 20f;
	
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
	}
}
