using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text.RegularExpressions;

public class casute1 : MonoBehaviour
{
    public InputField r1;
    public GameObject Nr;
    public GameObject cub1;
    public GameObject cub2;
    public GameObject cub3;
    public GameObject cub4;
    public GameObject Nr2;
    public Text txt;
    public int i;
    public void Answer()
    {
        i = 0;
        if (r1.text == "30")
        {
            i = i + 1;
            txt.text = "Răspuns corect";
            Nr.SetActive(true);
            Delay();
            cub1.SetActive(true);
            Delay();
            cub2.SetActive(true);
            Delay();
            cub3.SetActive(true);
            Delay();
            cub4.SetActive(true);
        }
        else
        {
            
            txt.text = "Răspuns greșit";
            Nr.SetActive(true);
            Nr2.SetActive(true);
            Delay();
            cub1.SetActive(true);
            Delay();
            cub2.SetActive(true);
            Delay();
            cub3.SetActive(true);
            Delay();
            cub4.SetActive(true);
            Delay();


        }

    }
    public void onsubmit()
    { Answer(); }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
    }

}