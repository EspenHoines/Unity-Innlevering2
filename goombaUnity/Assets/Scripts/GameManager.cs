using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{

    public bool IsMenuActive { get; set; }
    
    void Awake()
    {
        IsMenuActive = true;

        Application.runInBackground = true;

        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        const int Width = 400;
        const int Height = 300;
        
        if (IsMenuActive)
        {
            Rect windowRect = new Rect((Screen.width - Width) / 2,
                                       (Screen.width - Height) / 2,
                                        Width, Height);
        }
	}
}
