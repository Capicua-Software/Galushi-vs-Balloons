using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    TextMeshPro text;


    void Awake ()
    {
        text = GetComponent <TextMeshPro>();
        score = 0;
    }


    void Update ()
    {
        text.text = score.ToString();
    }


    public static void Score(int scoree)
    {
        score += scoree;
    }
}
