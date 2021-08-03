using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuPaused : MonoBehaviour
{

    public static bool gamepaused = false;
    public GameObject Menu;
    public GameObject PlayerMenu;
    public GameObject Player;
    public float inputThreshold = 0.1f;
    public XRNode inputSource;
    public InputHelpers.Button inputButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMenu.transform.rotation = Player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(inputSource), inputButton, out bool isPressed, inputThreshold);
        if (isPressed)
        {
            if (gamepaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        SetPosition();
        Menu.SetActive(false);
        Player.SetActive(true);
        PlayerMenu.SetActive(false);
        Time.timeScale = 1f;
        gamepaused = false;
    }

    public void Pause()
    {
        SetPosition();
        Menu.SetActive(true);
        Player.SetActive(false);
        PlayerMenu.SetActive(true);
        Time.timeScale = 0f;      
        gamepaused = true;       
    }

    public void SetPosition()
    {
        PlayerMenu.transform.rotation = Player.transform.rotation;
        PlayerMenu.transform.position = Player.transform.position;
    }

   


}
