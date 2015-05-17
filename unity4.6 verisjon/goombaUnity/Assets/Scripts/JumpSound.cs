using UnityEngine;
using System.Collections;

public class JumpSound : MonoBehaviour {

    private float ttl;

	// Use this for initialization
	void Start () {

        AudioSource sound = this.GetComponent<AudioSource>();
        ttl = sound.clip.length;

	}
	
	// Update is called once per frame
	void Update () {

        ttl -= Time.deltaTime;

        if (ttl <= 0f)
        {
            Destroy(this.gameObject);
        }
	
	}
}
