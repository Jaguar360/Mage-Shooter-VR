using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {

    public float speed = 25f;
    public float lifeDuration = 1f;
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

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Enemy")
        {
            enemy = other.GetComponent<Enemy>();

            enemy.TakeDamage(25);

            // award points to player
            // gameManager.AddScore(1000);
        }

        Destroy(gameObject);
    }
}