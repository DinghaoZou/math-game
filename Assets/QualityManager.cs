using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualityManager : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    public string resolutionSelected;

    void Start() {
        resolutionSelected = PlayerPrefs.GetString("qualityLevel");
    }

    // Start is called before the first frame update
    /* void Start()
    {
        int index = resolutionDropdown.value;
        resolutionSelected = resolutionDropdown.options[index].text;

        if (resolutionSelected == "1920 x 1080") {
            Screen.SetResolution(1920, 1080, true);
        } else if (resolutionSelected == "1600 x 900") {
            Screen.SetResolution(1600, 900, true);
        } else if (resolutionSelected == "1280 x 720") {
            Screen.SetResolution(1280, 720, true);
        } else if (resolutionSelected == "960 x 540") {
            Screen.SetResolution(960, 540, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int index = resolutionDropdown.value;
        resolutionSelected = resolutionDropdown.options[index].text;

        if (resolutionSelected == "1920 x 1080") {
            Screen.SetResolution(1920, 1080, true);
        } else if (resolutionSelected == "1600 x 900") {
            Screen.SetResolution(1600, 900, true);
        } else if (resolutionSelected == "1280 x 720") {
            Screen.SetResolution(1280, 720, true);
        } else if (resolutionSelected == "960 x 540") {
            Screen.SetResolution(960, 540, true);
        }
    } */

    public void changeOfResolution () {
        int index = resolutionDropdown.value;
        resolutionSelected = resolutionDropdown.options[index].text;

        if (resolutionSelected == "Amazing") {
            QualitySettings.SetQualityLevel(4, true);
        } else if (resolutionSelected == "Great") {
            QualitySettings.SetQualityLevel(3, true);
        } else if (resolutionSelected == "Okay") {
            QualitySettings.SetQualityLevel(2, true);
        } else if (resolutionSelected == "Low") {
            QualitySettings.SetQualityLevel(1, true);
        }

        Debug.Log(QualitySettings.GetQualityLevel());
        PlayerPrefs.SetString("qualityLevel", resolutionSelected);
    }
}
