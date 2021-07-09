using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBalloonSpawns : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject greenballoon;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawn()
    {
        int i = Random.Range(0, 8);
        Instantiate(greenballoon, SpawnPoints[i].position, transform.rotation = Quaternion.Euler(180, 0, 0));
    }
}
