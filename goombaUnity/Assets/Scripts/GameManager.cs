using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public AudioClip BackgroundSound;

    private AudioSource m_SoundSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
