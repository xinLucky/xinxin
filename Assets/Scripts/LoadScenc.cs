using UnityEngine;
using System.Collections;

public class LoadScenc : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Load()
    {
        
        Application.LoadLevel(1);
        

    }
}
