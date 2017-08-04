using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move_A_To_B3: MonoBehaviour
{
    public Transform target;
    private int ok = 0;
    public float speed;
    public GameObject buton1;
    public GameObject buton2;
    public GameObject buton3;
    public void ClickToChange()
    {
     ok = 1;
        if (ok == 1)
        {
            buton3.SetActive(false);
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