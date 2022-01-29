using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    public Text m_Text1;
    public Text m_Text2;
    public bool m_Fading;

    public bool timerGo;
    public float timer;
    public float countdown;
    public GameObject scriptCam;

    private void Start()
    {
        
    }

    void Update()
    {

        if (timerGo == false)
        {
            m_Fading = false;
        }

        if (timerGo == true)
        {
            m_Fading = true;
            countdown = countdown - Time.deltaTime;
        }

        if (countdown < 0)
        {
            timerGo = false;
            countdown = timer;
            
        }


        if (m_Fading == false)
        {
            m_Text1.CrossFadeAlpha(1, 1, false);
            m_Text2.CrossFadeAlpha(1, 1, false);
        }

        if (m_Fading == true)
        {
            m_Text1.CrossFadeAlpha(0, 1, false);
            m_Text2.CrossFadeAlpha(0, 1, false);
        }

        if (scriptCam.GetComponent<CameraMovement>().chosenA == true || scriptCam.GetComponent<CameraMovement>().chosenB == true)
        {
            timerGo = true;
        }



    }




    void OnGUI() 
        {
            m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
        }
}


