using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;
    public static bool level2;
    Animator anim;
	float restartTimer;
    Text txt;
    public GameObject tm;
    public static int scene, nextscene;

    void Awake()
    {
        txt = tm.GetComponent<Text>();
        anim = GetComponent<Animator>();
        scene = SceneManager.GetActiveScene().buildIndex;

        if (level2)
        {
            nextscene = 4;
        }
        else
        {
            nextscene = 3;
        }

        if (scene == 2)
        {
            StartCoroutine(Animat("¿Estas Listo?", 0));
            StartCoroutine(Animat("3", 4));
            StartCoroutine(Animat("2", 6));
            StartCoroutine(Animat("1", 8));
            StartCoroutine(Animat("EMPECEMOS", 10));
            StartCoroutine(ResetAnimat(11, nextscene));
        }
    }


    void Update()
    {
       
        if (playerHealth.currentHealth <= 0)
        {
            txt.text = "Game Over!";
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
              int scene = SceneManager.GetActiveScene().buildIndex;
              SceneManager.LoadScene(scene);
            }
          
        }
        

        else if (ScoreManager.score>=500 && !level2)
        {
            txt.text = "NIVEL COMPLETO";
            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                level2 = true;
                SceneManager.LoadScene(2);
            }
        }
        else if (ScoreManager.score >= 500 && level2)
        {
            txt.text = "JUEGO TERMINADO";
            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(1);
            }
        }
      // ScoreManager.score = 500;
    }

    IEnumerator Animat(string texto, int seconds)
    {
        yield return new WaitForSeconds(seconds);

        txt.text = texto;
        anim.SetTrigger("GameOver");

    }

    IEnumerator ResetAnimat(int seconds, int nextscene)
    {

        yield return new WaitForSeconds(seconds);       
        SceneManager.LoadScene(nextscene);

    }








}
