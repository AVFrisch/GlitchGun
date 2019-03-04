using UnityEngine;
using System.Collections;

public class AngledMover : MonoBehaviour
{
    public float speed;

    void Start()
    {
       
        
        
        //v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
        //v3T = Camera.main.ScreenToWorldPoint(v3T);
        //transform.LookAt(v3T);


    }

    //
    void Update()
    {

        Vector3 v3T = transform.forward * speed;
        GetComponent<Rigidbody>().velocity = v3T;



        //    Vector3 v3T = Input.mousePosition;
        //    v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
        //    v3T = Camera.main.ScreenToWorldPoint(v3T);
        //    transform.LookAt(v3T);

        //    GetComponent<Rigidbody>().velocity = v3T;
    }
}