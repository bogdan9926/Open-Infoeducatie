using UnityEngine;
using System.Collections;

public class Move_A_To_B1: MonoBehaviour
{
    public Transform target;
    private int ok = 0;
    public float speed;
    public void ClickToChange()
    {
     ok = 1;
        Destroy(this, 2);
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