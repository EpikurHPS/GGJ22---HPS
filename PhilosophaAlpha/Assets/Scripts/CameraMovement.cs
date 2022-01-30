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

    public float rotationSpeed = 5;
    public Camera cam;

    public bool chosenA;
    public bool chosenB;

    public int clickCounter;
    public float counter;
    public float goCounter;
    public bool startCounter;

    private void Start()
    {
        chosenA = false;
        chosenB = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startCounter == true)
        {
            counter -= Time.deltaTime;
        }
        if(counter < 0)
        {
            counter = goCounter;
            startCounter = false;
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
            if(hitinfo.collider.tag == "OptionA")
            {
                image.gameObject.SetActive(true);
                if (Input.GetMouseButtonDown(0) && startCounter == false)
                {
                    startCounter = true;
                    clickCounter += 1;
                    chosenA = true;
                    Debug.Log("ClickA");
                }
            }
            else if (hitinfo.collider.tag == "OptionB")
            {
                image.gameObject.SetActive(true);
                if (Input.GetMouseButtonDown(0) && startCounter == false)
                {
                    startCounter = true;
                    clickCounter += 1;
                    chosenB = true;
                    Debug.Log("ClickB");
                }
            }
            else if (hitinfo.collider.tag == "OptionA" || hitinfo.collider.tag != "OptionB")
            {
                
                image.gameObject.SetActive(false);
            }

        }

        if(chosenA == true || chosenB == true)
        {
            Invoke("SetBoolBack", 1f);
        }

    }

    public void SetBoolBack()
    {
        chosenA = false;
        chosenB = false;
    }

    
}
