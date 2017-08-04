using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Variable : MonoBehaviour {
    public GameObject Cub;
    public ParticleSystem Particle;
    public GameObject CubDistrus;
    public GameObject CubNou;
    public 
    // Use this for initialization
    void Start () {
        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds (2);
        Destroy(Particle);
        Destroy(CubDistrus);
        CubNou.SetActive(true);
    }
        // Update is called once per frame
        void Update () {
		
	}
    public void ClickToChange()
    {
        StartCoroutine(Delay());
        
    }
}
