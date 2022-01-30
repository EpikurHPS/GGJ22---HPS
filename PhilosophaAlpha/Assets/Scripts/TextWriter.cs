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


        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 1) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 1))
        {
            soundControl.GetComponent<SoundController>().answer0 = true;
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            m_Text1.text = "0";
            m_Text2.text = "10";

            Debug.Log(scriptCam.GetComponent<CameraMovement>().chosenA);
        }


        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 2) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 2))
        {
            soundControl.GetComponent<SoundController>().answer11 = true;
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            m_Text1.text = "Attraktivität?";
            m_Text2.text = "Skala von 1 bis 10?";
            
            Debug.Log(scriptCam.GetComponent<CameraMovement>().chosenA);
        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 3) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 3))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer12 = true;
            m_Text1.text = "Was tun wir hier?";
            m_Text2.text = "Was willst du von mir?";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 4) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 4))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer21 = true;
            m_Text1.text = "Reden? Worüber?";
            m_Text2.text = "Alles klar. Schieß los.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 5) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 5))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer22 = true;
            m_Text1.text = "Ja.";
            m_Text2.text = "Nein.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 6) && (scriptCam.GetComponent<CameraMovement>().chosenB == false && scriptCam.GetComponent<CameraMovement>().clickCounter == 6))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            scriptCam.GetComponent<CameraMovement>().clickCounter = 10;
            soundControl.GetComponent<SoundController>().answer31 = true;
            m_Text1.text = "Ich kann mein direktes Umfeld beeinflussen. Vielleicht nicht die ganze Welt, aber ich selbst fühle mich ständig von anderen Menschen inspiriert, wer sagt, dass ich nicht auch so eine Wirkung auf mein unmittelbares Umfeld haben kann?";
            m_Text2.text = "Weil selbst mein kleiner Anteil im Gesamtgefüge einen Effekt haben kann. Ein Schmetterling kann schließlich ja auch einen Orkan auslösen, der die Welt verändert.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 11) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 11))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer32 = true;
            m_Text1.text = "Wie ich mein Geld ausgeben ist vielleicht der direkteste Weg für mich als Individuum meine Macht auszuüben. Ich habe als einzelner Mensch begrenzte Ressourcen, aber die kann ich ja so einsetzen, wie ich will. Z.B. wenn ich versuche, nur Produkte zu kaufen, die nicht unter Tierleid oder menschlicher Ausbeutung entstanden sind.";
            m_Text2.text = "Ich schaue bei vielen Entscheidungen auf meinen eigenen CO2 Fußabdruck und entscheide demnach ob ich etwas machen oder konsumieren will. Je nachdem wie es im Verhältnis steht.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 12) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 12))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer41 = true;
            scriptCam.GetComponent<CameraMovement>().clickCounter = 19;
            m_Text1.text = "Weil ich es kann. Und weil ich es möchte. Ich  kann für mich entscheiden, dass ich mein Geld den Herstellern gebe, die es für mich verdient haben";
            m_Text2.text = "Doch, wird es.  Selbst ich als einzelne Person habe einen Einfluss darauf, wie sich die Welt (und damit das Klima) entwickelt. Ich will meinen Beitrag leisten und fühle mich fast sogar ein bisschen verpflichtet dazu.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 20) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 20))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer42 = true;
            m_Text1.text = "Ich kaufe mir damit auch ein gewisses Selbstbild, mit dem ich zufrieden bin. Das ich vertreten kann. Es ist fast ein bisschen wie Ablasshandel für mich. Ohne das religiöse Element.";
            m_Text2.text = "Nachhaltige Produkte sind ein Ansatzpunkt um die Klimasituation zu verbessern. Werden mehr nachhaltige Produkte gekauft steigt der Markt für diese und die Verkaufszahl der herkömmlichen Produkte geht zurück. Damit geht dann schlussendlich auch die Produktion dieser Waren zurück.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 20) || (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 13))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            soundControl.GetComponent<SoundController>().answer51 = true;
            m_Text1.text = "Ja. Wenn sich nur jeder ein bisschen ändert und andere zum Umdenken bewegt, kann etwas in der Sache erreicht werden.";
            m_Text2.text = "Nein, aber ich glaube dennoch das jeder einzelne seinen Beitrag dazu leisten sollte.";

        }

        if ((scriptCam.GetComponent<CameraMovement>().chosenA == false && scriptCam.GetComponent<CameraMovement>().clickCounter == 6) && (scriptCam.GetComponent<CameraMovement>().chosenB == true && scriptCam.GetComponent<CameraMovement>().clickCounter == 6))
        {
            scriptCam.GetComponent<CameraMovement>().chosenA = false;
            scriptCam.GetComponent<CameraMovement>().chosenB = false;
            scriptCam.GetComponent<CameraMovement>().clickCounter = 100;
            soundControl.GetComponent<SoundController>().answer31 = true;
            m_Text1.text = "Der Energieverbrauch von Regierungssachen ist astromonisch groß im Vergleich zu mir";
            m_Text2.text = "Mein Faktor gesehen auf Energieverbrauch von Staaten, Crypto, bla ist mein prozentualer Anteil viel zu klein dass es sich lohnt da zeit reinzustecken um was zu ändern";

        }

    }




    void OnGUI() 
        {
            m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
        }
}


