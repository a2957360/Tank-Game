using UnityEngine;
using System.Collections;

public class bulletcontrol : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target")
        {
            GameObject gm = GameObject.Find("Gamescore");
            if (gm != null)
            {
                //get the scoreMgr component and add to the score
                scoremanage sm = gm.GetComponent<scoremanage>();
                if (sm != null)
                {
                    sm.addscore();
                    SEcontrol.PlayImpactSound();
                    Destroy(this.gameObject);
                }
            }
        }
        else
        {
            GameObject gm = GameObject.Find("Gamescore");
            if (gm != null)
            {
                //get the scoreMgr component and add to the score
                scoremanage sm = gm.GetComponent<scoremanage>();
                if (sm != null)
                {
                    sm.delscore();
                    SEcontrol.PlayMissSound();
                    Destroy(this.gameObject);
                }
            }

        }

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
