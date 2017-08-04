using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEcran : MonoBehaviour {
    public GameObject Ecran;
    // Use this for initialization
    void Start () {
        StartCoroutine(Delay());

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        Ecran.SetActive(true);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
