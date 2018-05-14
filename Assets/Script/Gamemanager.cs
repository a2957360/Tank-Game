using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gamemanager : MonoBehaviour {
    private GameObject[] target;
    Text gamefinish;
    Text finalscore;
    Text scorelabel;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        target = GameObject.FindGameObjectsWithTag("target");
        if (target.Length == 0)
        {
            gamefinish = GameObject.Find("Canvas/gamefinish").GetComponent<Text>();
            gamefinish.enabled = true;
            finalscore = GameObject.Find("Canvas/finalscore").GetComponent<Text>();
            scorelabel = GameObject.Find("Canvas/scorelabel").GetComponent<Text>();
            finalscore.text = scorelabel.text;
        }

    }
}
