using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{

    public GameObject projectile;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            fireMagic();
        }

        if (OVRInput.Get(OVRInput.RawButton.RTouchpad)) 
        {
            fireMagic();
        }
    }

    public void fireMagic()
    {
        GameObject magic = Instantiate(projectile);
        magic.transform.position = player.transform.position + player.transform.forward;
        magic.transform.forward = player.transform.forward;
    }
}