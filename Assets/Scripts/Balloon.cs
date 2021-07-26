using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    [SerializeField] private float power = 10;
    private Rigidbody rigidbody;
    float upinput;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        upinput = Input.GetAxis("Vertical");
        rigidbody.AddForce(Vector3.up * power, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
