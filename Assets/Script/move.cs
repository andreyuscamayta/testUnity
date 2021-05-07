using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    private float y;
    private float rate;
    private bool jump;
    private bool up;
    void Start()
    {
        y = 0.5f;
        rate = .01f;
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("deltaTime"+Time.deltaTime);
        Debug.Log("Input.GetAxis(Vertical)" + Input.GetAxis("Vertical"));
        Debug.Log("Input.GetAxis(Horizontal)" + Input.GetAxis("Horizontal"));
        Debug.Log("Input.GetAxis(Mouse X)" + Input.GetAxis("Mouse X"));
        Debug.Log("Input.GetAxis(Mouse Y)" + Input.GetAxis("Mouse Y"));
        Debug.Log("transform.position" + transform.position);
        Debug.Log("transform.rotation" + transform.rotation);
        Debug.Log("transform.localScale" + transform.localScale);
        transform.localScale+= new Vector3(-0.01f, -0.01f, -0.01f); ;*/
        if (Input.GetKeyDown("space"))
        {
            jump = true;
            up = true;
        }
        if (jump)
        {
            if(up)
            {
                y += rate;
            }
            else 
            {
                y -= rate;
            }
            if(y > 5)
            {
                up = false;
            }
            if(y <= .5)
            {
                jump = false;
            }
        }
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
