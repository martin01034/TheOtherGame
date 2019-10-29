using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 15;
    
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        Vector3 movement = new Vector3();
        if (Input.GetKey("a"))
        {                                                                                    
            movement += new Vector3(-speed, 0);
        }
        if (Input.GetKey("d"))
        {
            movement += new Vector3(speed, 0);
        }
        if (Input.GetKey("s"))
        {
            movement += new Vector3(0, 0, -speed);
        }
        if (Input.GetKey("w"))
        {
            movement += new Vector3(0, 0, speed);
        }
        //if no key is pressed then do nothing
        if (movement != Vector3.zero)
        {
            //otherwise set the rotation of the player and the position
            this.transform.rotation = Quaternion.LookRotation(movement);
            this.transform.Translate(movement * Time.deltaTime, Space.World);
        }

        

    }
}
