using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoremanage : MonoBehaviour {

    public int score;
    Text text;

    public void addscore()
    {
        score += 5;
        text.text = score.ToString();
    }

    public void delscore()
    {
        score -= 1;
        text.text = score.ToString();
    }
    // Use this for initialization
    void Start () {
        text = GameObject.Find("Canvas/scorelabel").GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
