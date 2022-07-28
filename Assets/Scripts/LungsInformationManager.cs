using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LungsInformationManager : MonoBehaviour
{
    public TMP_Text displayText;
    public TMP_Text buttonText;

    [TextArea]
    public string vescularBreathing;
    public string vescularButtonTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void VescularBreathing()
    {
        displayText.text = vescularBreathing;
        buttonText.text = vescularButtonTxt;
    }

    public void ResetText()
    {
        displayText.text = " ";
        buttonText.text = "Lungs";
    }
}
