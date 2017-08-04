using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Change : MonoBehaviour {

    public GameObject cube1;
    public GameObject cube2;
    public GameObject L1;
    public GameObject L2;
    public GameObject Block;
    bool red;
    bool green;
    public GameObject Bec1;
    public GameObject Bec2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (red == true)
        {
          L1.SetActive(true);
          L2.SetActive(false);
        }
        else
        {
            if (green == true)
            {
                L2.SetActive(true);
                L1.SetActive(false);
            }
        }
	}

    private void OnTriggerEnter(Collider cube1)
    {
        Bec1.SetActive(false);
        Bec2.SetActive(false);
        if (cube1.name == "Rosu")
        {
            red = true;
            green = false;
        }
        if (cube1.name == "Verde")
        {
            red = false;
            green = true;
        }
        if(cube1.name == "Ify")
        {
            if (green == true)
            {
                Bec1.SetActive(true);
            }
            if(red == true)
            {
                Bec2.SetActive(true);
            }
        }

    }
}
