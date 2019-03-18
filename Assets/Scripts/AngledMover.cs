using UnityEngine;
using System.Collections;

public class AngledMover : MonoBehaviour
{
    public float speed;

    void Start()
    {

        if (GetComponent<Rigidbody>().name.Contains("Burst")){
            GetComponent<Rigidbody>().transform.Rotate(0f, 10f, 0f, Space.Self);
        }

        print(GetComponent<Rigidbody>().name);

        Vector3 v3T = Input.mousePosition;
        v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
        v3T = Camera.main.ScreenToWorldPoint(v3T);
        transform.LookAt(v3T);


    }

    //
    void Update()
    {

        GetComponent<Rigidbody>().velocity = transform.forward * speed;

        //    Vector3 v3T = Input.mousePosition;
        //    v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
        //    v3T = Camera.main.ScreenToWorldPoint(v3T);
        //    transform.LookAt(v3T);

        //    GetComponent<Rigidbody>().velocity = v3T;
    }
}