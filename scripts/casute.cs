using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class casute : MonoBehaviour
{
    public InputField r1;
    public GameObject Nr;
    public GameObject Nr2;
    public Text txt;
    public int i;

    public void Answer()
    {
        i = 0;
        if (r1.text == "13")
        {
            i = i + 1;
            txt.text = "Răspuns corect";
            Nr.SetActive(true);
        }
        else
        {
            
            txt.text = "Răspuns greșit";
            Nr.SetActive(true);
            Nr2.SetActive(true);

        }

    }
    public void onsubmit()
    { Answer(); }


}