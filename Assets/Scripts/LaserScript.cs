using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private GameObject shoot;
    public GameObject Laser;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot = (GameObject)Instantiate(Laser, transform.position + new Vector3(0, 0.2f, 0), transform.rotation);
            shoot.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,5),ForceMode.Impulse);
        }
    }
}
