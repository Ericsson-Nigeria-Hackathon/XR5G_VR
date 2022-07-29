using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Button openRollOutButton, heartButton, lungsButton, rollOutButton;
    public GameObject rollOut, goodHeartContent, badHeartContent, lungsContent;
    public RectTransform arrow;
    public string lungsRolloutTxt, heartRolloutTxt;
    public TMP_Text openRolloutText, rollOutText, displayText;
    public HeartInformationManager heartInformationManager;

    void Start()
    {
        rollOutButton.onClick.AddListener(() => RollOutContent());
        openRollOutButton.onClick.AddListener(() => OpenRollOut());
        heartButton.onClick.AddListener(() => HeartContent());
        lungsButton.onClick.AddListener(() => LungsContent());

        openRolloutText.text = "Heart";
        rollOutText.text = heartRolloutTxt;
    }

    private void OpenRollOut()
    {
        rollOut.SetActive(!rollOut.activeSelf);
        arrow.Rotate(0, 0, 180);
    }

    private void HeartContent()
    {
        openRolloutText.text = "Heart";
        rollOutText.text = heartRolloutTxt;
        goodHeartContent.SetActive(true);
        lungsContent.SetActive(false);
        ResetText();
    }

    private void LungsContent()
    {
        openRolloutText.text = "Lungs";
        rollOutText.text = lungsRolloutTxt;
        lungsContent.SetActive(true);
        goodHeartContent.SetActive(false);
        badHeartContent.SetActive(false);
        ResetText();
    }

    private void RollOutContent()
    {
        //if (openRolloutText.text == "Heart")
        //{
            openRolloutText.text = heartRolloutTxt;
            rollOutText.text = "Heart";
            BadSoundContent();
            goodHeartContent.SetActive(false);
            badHeartContent.SetActive(true);
        displayText.text = " ";
        //}
        //else if (openRolloutText.text == heartRolloutTxt)
        //{
        //    openRolloutText.text = heartRolloutTxt;
        //    goodHeartContent.SetActive(false);
        //    badHeartContent.SetActive(true);
        //}

        //if (openRolloutText.text == "Lungs")
        //{
        //    openRolloutText.text = lungsRolloutTxt;
        //}
        //else
        //    return;
    }

    private void BadSoundContent()
    {
        heartInformationManager.mitral = heartInformationManager.mitralBad;
        heartInformationManager.tricuspid = heartInformationManager.tricuspidBad;
        heartInformationManager.erb = heartInformationManager.erbBad;
        heartInformationManager.pulmonic = heartInformationManager.pulmonicBad;
        heartInformationManager.aortic = heartInformationManager.aorticBad;
    }

    public void ResetText()
    {
        heartInformationManager.displayText.text = " ";
        //heartInformationManager.buttonText.text = "Heart";
    }
}
