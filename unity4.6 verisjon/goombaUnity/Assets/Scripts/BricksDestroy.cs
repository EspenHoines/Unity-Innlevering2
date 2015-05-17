using UnityEngine;
using System.Collections;

public class BricksDestroy : MonoBehaviour {

        void OnCollisionEnter (Collision other)
	{
		Destroy(gameObject);
	}
}
