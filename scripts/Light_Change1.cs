using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Change1 : MonoBehaviour {

    public GameObject cube1;
    public GameObject cube2;
    public GameObject L1;
    public GameObject L2;
    bool red;
    bool green;
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
        red = true;
        green = false;
    }
    /*private void OnTriggerEnter(Collider cube2)
    {
        red = false;
        green = true;
    }*/
}
