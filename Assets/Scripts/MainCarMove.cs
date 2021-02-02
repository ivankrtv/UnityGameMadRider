using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarMove : MonoBehaviour
{
    private float x;
    public static float speed = 10f;
    public bool isCrashed = false;
    private Vector3 vec = new Vector3(1, 0, 0);


    void Update()
    {
        x = transform.position.x;
        if (Input.GetKey(KeyCode.A) && x > -2 && isCrashed == false)
        {
            transform.Translate(-speed * vec * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && x < 2 && isCrashed == false)
        {
            transform.Translate(speed * vec * Time.deltaTime);
        }
        
        //if(isCrashed == true)
        //{
        //    z = transform.position.z;
        //    transform.Translate(-10 * vecAfterCrash * Time.deltaTime);
        //    //gameObject.GetComponent<Rigidbody>().useGravity = false;
        //    //Road.GetComponent<RoadMove>().speed -= breakSpeed*Time.deltaTime;
        //    if(z < -7)
        //    {
        //        Destroy(gameObject);
        //    }
        //}
    }
}
