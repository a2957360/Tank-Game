using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// this class moves the tank and fires when
// fire button is pressed!
public class Tankcontrol : MonoBehaviour
{
    // bullet controls
    public GameObject buttlet;
    private GameObject bullletloc;
    private Vector3 buttletcontrol; 
    public float bulletspeed;
    Text Ltext;
    Text Rtext;

    //public SoundMgr sm;

    // Use this for initialization
    void Start()
    {

        // find my fire location, so we always spawn projectiles from there
        bulletloc buloc = this.gameObject.GetComponentInChildren<bulletloc>();
        if (buloc != null)
        {
            bullletloc = buloc.gameObject;
        }

    }

    public void TankCtrlUpdate()
    {
        trackconrol();
        if (Ltext.text == "Forward" && Rtext.text == "Stop")
        {
            transform.Translate(1.0f * Vector3.back * 0.1f);
            transform.Rotate(Vector3.up, 1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Backward" && Rtext.text == "Stop")
        {
            transform.Translate(-1.0f * Vector3.back * 0.1f);
            transform.Rotate(Vector3.up, 1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Stop" && Rtext.text == "Forward")
        {
            transform.Translate(1.0f * Vector3.back * 0.1f);
            transform.Rotate(Vector3.up, -1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Stop" && Rtext.text == "Backward")
        {
            transform.Translate(-1.0f * Vector3.back * 0.1f);
            transform.Rotate(Vector3.up, -1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Forward" && Rtext.text == "Forward")
        {
            transform.Translate(1.0f * Vector3.back * 0.1f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Backward" && Rtext.text == "Backward")
        {
            transform.Translate(-1.0f * Vector3.back * 0.1f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Forward" && Rtext.text == "Backward")
        {
            transform.Rotate(Vector3.up, 1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Backward" && Rtext.text == "Forward")
        {
            transform.Rotate(Vector3.up, -1.0f);
            SEcontrol.PlayTankmove();
        }
        if (Ltext.text == "Stop" && Rtext.text == "Stop")
        {
            //SEcontrol.PlayTankidle();
        }
        //directcontrol.x = Input.GetAxis("Horizontal");
        //directcontrol.z = Input.GetAxis("Vertical");
        //Vector3 vDisp = Vector3.back; 
        //transform.Translate(directcontrol.z * vDisp * 0.1f); 
        //transform.Translate(directcontrol.x * Vector3.left * 0.1f);
        //transform.Rotate(Vector3.up, directcontrol.x);
        if (Input.GetKeyDown("space"))
        {
            Tankfire();
            //up down left right control
        }
    }

    public void trackconrol()
    {
        Ltext = GameObject.Find("Canvas/Lefttrackstate").GetComponent<Text>();
        Rtext = GameObject.Find("Canvas/Righttrackstate").GetComponent<Text>();
        if (Input.GetKey("w"))
        {
            Ltext.text = "Forward";
        }
        else if (Input.GetKey("s"))
        {
            Ltext.text = "Backward";
        }
        else
        {
            Ltext.text = "Stop";
        }

        if (Input.GetKey("e"))
        {
            Rtext.text = "Forward";
        }
        else if (Input.GetKey("d"))
        {
            Rtext.text = "Backward";
        }
        else
        {
            Rtext.text = "Stop";
        }
    }

    public void Tankfire()
    {

            GameObject projInstance =
                (GameObject)Instantiate(buttlet, bullletloc.transform.position, bullletloc.transform.rotation);

            if (projInstance != null)
            {
            SEcontrol.PlayFireSound();
            Rigidbody bullectrg = projInstance.GetComponent<Rigidbody>();
                if (bullectrg != null)
                {
                    buttletcontrol = projInstance.transform.forward; // ?
                    buttletcontrol.Scale(new Vector3(bulletspeed, bulletspeed, bulletspeed));
                    bullectrg.AddForce(buttletcontrol);
                }
            }
        
    }

    // Update is called once per frame
    void Update()
    {

        TankCtrlUpdate();
    }
}

