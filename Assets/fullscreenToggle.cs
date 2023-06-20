using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullscreenToggle : MonoBehaviour
{
    public Text fullscreenButtonSwitch;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
