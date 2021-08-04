using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoading : MonoBehaviour
{

    public GameObject screenload;
   
    public Slider slider;
    float timer;
    public void LoadLevel (int index)
    {
        screenload.SetActive(true);       
        StartCoroutine(timere());
        StartCoroutine(LoadAsync(index));
       
    }
    IEnumerator LoadAsync(int index)
    {
        yield return new WaitForSeconds(8);
        
        SceneManager.LoadSceneAsync(index);
    }

    IEnumerator timere()
    {
        yield return new WaitForSeconds(1);

        while (timer < 1.0f)
        {
            timer ++;
            slider.value = timer;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
