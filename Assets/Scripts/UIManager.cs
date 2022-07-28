using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button bodyPartsButton, heartButton, lungsButton;
    public GameObject rollOut, heartContent, lungsContent;
    public RectTransform arrow;
    // Start is called before the first frame update
    void Start()
    {
        bodyPartsButton.onClick.AddListener(() => OpenRollOut());
        heartButton.onClick.AddListener(() => HeartContent());
        lungsButton.onClick.AddListener(() => LungsContent());
    }

    private void OpenRollOut()
    {
        rollOut.SetActive(!rollOut.activeSelf);
        arrow.Rotate(0, 0, 180);
    }

    private void HeartContent()
    {
        heartContent.SetActive(true);
        lungsContent.SetActive(false);
    }

    private void LungsContent()
    {
        lungsContent.SetActive(true);
        heartContent.SetActive(false);
    }
}
