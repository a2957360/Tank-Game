using UnityEngine;
using System.Collections;

public class Changecene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GoNextScene();

    }

    public void GoNextScene()
    {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel("playscene");
        //change to playscene
        }
        
    }
}
