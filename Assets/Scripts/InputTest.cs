using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour {

    public Text text;
    public GameObject box;
    public GameObject box2;
    public GameObject box3;

    private Material boxM;

	// Use this for initialization
	void Start () 
    {
		boxM = box.GetComponent<Renderer>().material;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) 
        {
            text.text = "Trigger pressed";
            if (box2.activeSelf) 
            {
                box2.SetActive(false);
            }

            else 
            {
                box2.SetActive(true);
            }

            boxM.color = Color.red;
        }

        else if (OVRInput.Get(OVRInput.RawButton.RTouchpad) || OVRInput.GetDown(OVRInput.RawButton.RTouchpad)) 
        {
            text.text = "Round button pressed";
            if (box3.activeSelf)
            {
                box3.SetActive(false);
            }

            else
            {
                box3.SetActive(true);
            }

            boxM.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A)) 
        {
            text.text = "Key pressed";
            boxM.color = Color.blue;
        }
	}
}
