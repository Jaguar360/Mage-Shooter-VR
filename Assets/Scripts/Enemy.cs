using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private bool dead = false;
    //public GameObject projectile;
    private GameManager gameManager;
    private int hp;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        hp = 100;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log("Enemy took" + damage + "damage");
        if (hp <= 0)
        {
            MakeDead(true);
        }
    }

    public void MakeDead(bool ded)
    {
        dead = ded;
        Debug.Log("Enemy got bodied");
    }

    public bool IsDead()
    {
        return dead;
    }

    private void Update()
    {
        if (dead == true)
        {
            Destroy(gameObject);
        }
    }

    //public IEnumerator Shoot()
    //  {
    //while (gameManager.IsGameOver() == false) 
    //{
    //          yield return new WaitForSeconds(3);
    //          GameObject bullet = (GameObject)Instantiate(projectile);
    //          bullet.transform.position = transform.position + transform.forward;
    //          bullet.transform.forward = transform.forward;
    //}
    //}
}