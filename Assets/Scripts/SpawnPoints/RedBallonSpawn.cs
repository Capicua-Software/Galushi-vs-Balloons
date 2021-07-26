using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallonSpawn : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject redballoon;
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
        int i = Random.Range(0, 6);
        Instantiate(redballoon, SpawnPoints[i].position, transform.rotation = Quaternion.Euler(180, 0, 0));
    }
}
