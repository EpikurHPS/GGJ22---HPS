using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public Image image;
    public bool rotaFreeze;

    public float rotationSpeed = 5;
    public Transform guy;
    public Camera cam;



    private void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        

        if (rotaFreeze == true)
        {
            //speedV = 0f;
            //speedH = 0f;
            
        }
        else
        {
            speedV = 2.0f;
            speedH = 2.0f;
        }


        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -50f, 50f);
        yaw = Mathf.Clamp(yaw, -30f, 30f);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetMouseButton(1))
        {
            Camera.main.fieldOfView = 30;
        }
        else
        {
            Camera.main.fieldOfView = 58;
        }


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f))
        {
            if(hitinfo.collider.tag == "Options")
            {
                image.gameObject.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    //Hier kommt die Interaktion
                    rotaFreeze = true;
                    Debug.Log("Click");
                }
            }
            else if (hitinfo.collider.tag != "Options")
            {
                image.gameObject.SetActive(false);
            }

        }

    }

    
}
