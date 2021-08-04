using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOMenu : MonoBehaviour
{

  
    void Start()
    {


        StartCoroutine(Menu());

    }
     IEnumerator Menu()
     {
        yield return new WaitForSeconds(8);
        LoadLevel(1);
    }

    public GameObject screenload;
    public GameObject Player;
    public GameObject video;
    public Slider slider;
    float timer;
    public void LoadLevel(int index)
    {
        Player.SetActive(true);
        video.SetActive(false);
        screenload.SetActive(true);
         StartCoroutine(timere());

        StartCoroutine(LoadAsync(index));

    }
    IEnumerator LoadAsync(int index)
    {
        yield return new WaitForSeconds(8);

        SceneManager.LoadScene(index);
    }

    IEnumerator timere()
    {
        yield return new WaitForSeconds(1);

        while (timer < 1.0f)
        {
            timer++;
            slider.value = timer;
        }
    }


}
