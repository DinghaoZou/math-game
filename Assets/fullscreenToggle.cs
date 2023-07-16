using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullscreenToggle : MonoBehaviour
{   
    public string pesudoBoolFullscreen = "true";
    public Text fullscreenButtonSwitch;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetString("Fullscreen");

        if (pesudoBoolFullscreen == "true") {
            Screen.fullScreen = true;
            fullscreenButtonSwitch.text = "On";
        } else if (pesudoBoolFullscreen == "false") {
            Screen.fullScreen = false;
            fullscreenButtonSwitch.text = "Off";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.fullScreen) {
            fullscreenButtonSwitch.text = "On";
        } else if (!Screen.fullScreen) {
            fullscreenButtonSwitch.text = "Off";
        }
    }

    public void toggleFullscreen () {
        Screen.fullScreen = !Screen.fullScreen;
        
        if (!Screen.fullScreen) {
            pesudoBoolFullscreen = "false";
        } else if (Screen.fullScreen) {
            pesudoBoolFullscreen = "true";
        }

        PlayerPrefs.SetString("Fullscreen", pesudoBoolFullscreen);
    }
}
