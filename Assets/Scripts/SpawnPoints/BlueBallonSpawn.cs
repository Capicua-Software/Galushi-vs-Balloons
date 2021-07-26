using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallonSpawn : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject blueballoon;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 4, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawn()
    {
        int i = Random.Range(0, 6);
        Instantiate(blueballoon, SpawnPoints[i].position, transform.rotation = Quaternion.Euler(180, 0, 0));
    }
}
