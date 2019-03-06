using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float speed;

    void Start()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, speed);
        GetComponent<Rigidbody>().velocity = transform.forward * speed;

        if (gameObject.transform.position.z < -4)
        {
            speed = -4;
            //print("speed set");
        }

    }
}