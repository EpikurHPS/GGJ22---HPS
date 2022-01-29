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
    public GameObject soundControl;

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


        //Entscheidungen (Für Option A)

        if (scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().chosenB == false)
        {
            if(countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice1 == true)
            {
                if (soundControl.GetComponent<SoundController>().dudeVoice2 == false)
                {
                    m_Text1.text = "0";
                    m_Text2.text = "10";
                }
                
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice2 == true)
            {
                    soundControl.GetComponent<SoundController>().answer11 = true;
                    m_Text1.text = "Attraktivität?";
                    m_Text2.text = "Skala von 1 bis 10?";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice3 == true)
            {
                    soundControl.GetComponent<SoundController>().answer21 = true;
                    m_Text1.text = "Was tun wir hier?";
                    m_Text2.text = "Was willst du von mir?";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice4 == true)
            {
                soundControl.GetComponent<SoundController>().answer31 = true;
                m_Text1.text = "Reden? Worüber?";
                m_Text2.text = "Alles klar. Schieß los.";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice5 == true)
            {
                soundControl.GetComponent<SoundController>().answer41 = true;
                m_Text1.text = "Ja.";
                m_Text2.text = "Nein.";
            }


        }


        //Entscheidungen (Für Option B)

        if (scriptCam.GetComponent<CameraMovement>().chosenA == false && scriptCam.GetComponent<CameraMovement>().chosenB == true)
        {
            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice1 == true)
            {
                m_Text1.text = "0";
                m_Text2.text = "10";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice2 == true)
            {
                soundControl.GetComponent<SoundController>().answer12 = true;
                m_Text1.text = "Attraktivität?";
                m_Text2.text = "Skala von 1 bis 10?";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice3 == true)
            {
                soundControl.GetComponent<SoundController>().answer22 = true;
                m_Text1.text = "Was tun wir hier?";
                m_Text2.text = "Was willst du von mir?";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice4 == true)
            {
                soundControl.GetComponent<SoundController>().answer32 = true;
                m_Text1.text = "Reden? Worüber?";
                m_Text2.text = "Alles klar. Schieß los.";
            }

            if (countdown < 1 && soundControl.GetComponent<SoundController>().dudeVoice5 == true)
            {
                soundControl.GetComponent<SoundController>().answer42 = true;
                m_Text1.text = "Ja.";
                m_Text2.text = "Nein.";
            }


        }



    }




    void OnGUI() 
        {
            m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
        }
}


