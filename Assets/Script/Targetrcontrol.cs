using UnityEngine;
using System.Collections;

public class Targetrcontrol : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            Invoke("destroytarget",1.0f);
        }

    }
    public void destroytarget()
    {
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


}
