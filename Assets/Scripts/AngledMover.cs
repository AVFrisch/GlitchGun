using UnityEngine;
using System.Collections;

public class AngledMover : MonoBehaviour
{
    public float speed;
    public float spread = 15;

    void Start()
    {

        Vector3 v3T = Input.mousePosition;
        v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
        v3T = Camera.main.ScreenToWorldPoint(v3T);
        transform.LookAt(v3T);

        if (GetComponent<Rigidbody>().name.Contains("Burst"))
        {
            float randangle = Random.Range(-spread, spread);
            GetComponent<Rigidbody>().transform.Rotate(0f, randangle, 0f, Space.World);
            print("rotated");
        }

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