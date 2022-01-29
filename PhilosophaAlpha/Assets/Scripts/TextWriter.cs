using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    public Text m_Image;
    public bool m_Fading;

    void Update()
    {
        if (m_Fading == false)
        {
            m_Image.CrossFadeAlpha(1, 1.0f, false);
        }

        if (m_Fading == true)
        {
            m_Image.CrossFadeAlpha(0, 1.0f, false);
        }
    }

    void OnGUI()
    {
        m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
    }
}

