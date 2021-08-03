using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class Menushoot : MonoBehaviour
{
    void Update ()
    {

    }


    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void close()
    {
        Application.Quit();
    }

}
