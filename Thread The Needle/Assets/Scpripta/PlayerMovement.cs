using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class PlayerMovement : MonoBehaviour{
    // Start is called before the first frame update

    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(5000 * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
/*        for (int i = 0; i < 10; i++)
        {
            
        }*/

        //to check if button pressed

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, 1 * Time.deltaTime, ForceMode.VelocityChange);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, -10 * Time.deltaTime, ForceMode.VelocityChange);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 10 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, -10 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

       

        //to check if button not preesed


        /*        if (Input.GetKey(KeyCode.LeftArrow))
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.forward / 5, ForceMode.VelocityChange); 
                }

                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.back / 5, ForceMode.VelocityChange);
                }

                else if (Input.GetKey(KeyCode.UpArrow))
                { 
                    GetComponent<Rigidbody>().AddForce(Vector3.up / 5, ForceMode.VelocityChange);
                }

                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.down / 5, ForceMode.VelocityChange);
                }*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward / 5, ForceMode.VelocityChange);
        }
    }
}
    