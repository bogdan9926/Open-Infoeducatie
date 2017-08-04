using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move_A_To_B : MonoBehaviour
{
    public GameObject buton1;
    public GameObject buton2;
    public GameObject buton3;

    public Transform target;
    private int ok = 0;
    public float speed;
    void Start()
    {
        buton1.SetActive(true);

    }
    public void ClickToChange()
    {
        ok++; 
        Destroy(this, 2);
        if(ok==1)
        {
            buton1.SetActive(false);
            buton2.SetActive(true);
        }
    }
    void Update()
    {
    if(ok==1)
    {
        float pas = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, pas);
    }
        
    }
}