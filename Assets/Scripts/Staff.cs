using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    public GameObject player;
    private GameObject[] projectiles;

    // Use this for initialization
    void Start()
    {
        projectile = (GameObject)Resources.Load("Prefabs/Meteor");
        projectiles = new GameObject[3];
        projectiles[0] = (GameObject)Resources.Load("Prefabs/Meteor");
        projectiles[1] = (GameObject)Resources.Load("Prefabs/Spark");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            fireMagic();
        }

        else if (OVRInput.GetDown(OVRInput.RawButton.RTouchpad)) 
        {
            fireMagic();
        }

        if (Input.GetKeyDown(KeyCode.Space) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) 
        {
            Switch();
        }
    }

    public void fireMagic()
    {
        GameObject magic = Instantiate(projectile);
        magic.transform.position = player.transform.position + player.transform.forward;
        magic.transform.forward = player.transform.forward;
    }

    public void Switch() 
    {
        if (projectile == projectiles[0]) 
        {
            projectile = projectiles[1];
        }

        else if (projectile = projectiles[1]) 
        {
            projectile = projectiles[0];
        }
    }
}