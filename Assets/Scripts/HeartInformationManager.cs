using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeartInformationManager : MonoBehaviour
{
    public TMP_Text displayText;
    public TMP_Text buttonText;

    [TextArea]
    public string mitral, mitralBad;
    public string mitralButtonTxt;
    [TextArea]
    public string tricuspid, tricuspidBad;
    public string tricuspidButtonTxt;
    [TextArea]
    public string erb, erbBad;
    public string erbButtonTxt;
    [TextArea]
    public string pulmonic, pulmonicBad;
    public string pulmonicButtonTxt;
    [TextArea]
    public string aortic, aorticBad;
    public string aorticButtonTxt;

    public void MitralInformation()
    {
        displayText.text = mitral;
        buttonText.text = mitralButtonTxt;
    }

    public void TricuspidInformation()
    {
        displayText.text = tricuspid;
        buttonText.text = tricuspidButtonTxt;
    }

    public void ErbInformation()
    {
        displayText.text = erb;
        buttonText.text = erbButtonTxt;
    }

    public void PulmonicInformation()
    {
        displayText.text = pulmonic;
        buttonText.text = pulmonicButtonTxt;
    }

    public void AorticInformation()
    {
        displayText.text = aortic;
        buttonText.text = aorticButtonTxt;
    }

    public void ResetText()
    {
        displayText.text = " ";
        buttonText.text = "Heart";
    }
}
