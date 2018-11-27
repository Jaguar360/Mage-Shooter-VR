using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public float speed = 7f;
    public float lifeDuration = 3f;
    private float lifeTimer;

    //GameManager gameManager;
    private Enemy enemy;

    // Use this for initialization
    void Start()
    {
        lifeTimer = lifeDuration;
        // gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;

        if (lifeTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            enemy = other.gameObject.GetComponent<Enemy>();

            enemy.TakeDamage(25);



            // award points to player
            // gameManager.AddScore(1000);
        }
    }
}