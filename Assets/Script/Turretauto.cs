using UnityEngine;
using System.Collections;

public class Turretauto : MonoBehaviour {

    private float distance;
    private int tankstate = 0;

    // Use this for initialization

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "target")
        {
            turnturrettotarget(collider.gameObject.transform.position);
            tankstate = 1;
        }

    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "target")
        {
            turnforward();
            tankstate = 0;
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "target")
        {
            turnturrettotarget(collider.gameObject.transform.position);
            tankstate = 1;
        }
    }


    public float calculdistance(Vector3 position)
    {
        Tankcontrol tank = this.gameObject.GetComponentInParent<Tankcontrol>();
        distance = Vector3.Distance(position, tank.transform.position);
        return distance;
    }

    public void turnturrettotarget(Vector3 position)
    {

        Quaternion rotate = Quaternion.LookRotation(transform.position - position);
        rotate.x = 0;
        rotate.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * 2.0f);
        //Debug.Log(" change");
    }

    public void turnforward()
    {
        Tankcontrol tank = this.gameObject.GetComponentInParent<Tankcontrol>();
        Turretforward tforward = tank.GetComponentInChildren<Turretforward>();
        Quaternion forward = Quaternion.LookRotation(transform.position - tforward.transform.position);
        forward.x = 0;
        forward.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, forward, Time.deltaTime * 2.0f);

    }

    void Update ()
    {
        if (tankstate == 0)
        {
            turnforward();
        }

    }
    // Update is called once per frame

}
