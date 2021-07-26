using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    [SerializeField] private float power = 10;
    private Rigidbody rigidbody;
    float upinput;
    public int attackDamage = 10;

    float timer;
    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

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
        Attack();
        Destroy(gameObject);
       
    }

    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }

}
