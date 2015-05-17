using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public AudioClip BackgroundSound;
	public Text Time;
    public Text Score;

    static public int currentPoints = 0;
    int Points;

    private AudioSource m_SoundSource;

	int timeStart = 400;
	int timer;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () 
    {
		timer = timeStart;
		timerLoop ();


	}
	
	// Update is called once per frame
	void Update () 
    {
		if (timer == 0) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	void Countdown(){
		timer = timer - 1;
		Time.text = "TIME\n" + timer;
	}
	void timerLoop(){
		InvokeRepeating ("Countdown", 1, 1.0F);
	}

    void points(){
        Points += currentPoints;
        Score.text = "Score\n" + Points;
    }
}
