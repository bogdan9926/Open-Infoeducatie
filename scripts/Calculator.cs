using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    public InputField input1;
    public InputField input2;
    public GameObject Exit;
    public Text text;
    public GameObject yourButton1;
    public GameObject yourButton2;
    public GameObject yourButton3;
    public GameObject yourButton4;
    public GameObject yourButton5;
    public int x;
    public int y;
    public int t;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x = int.Parse(input1.text); //for integer 
        y = int.Parse(input2.text); //for integer
            Buttons();

    }
    void Buttons()
    {
        Button btn1 = yourButton1.GetComponent<Button>();
        Button btn2 = yourButton2.GetComponent<Button>();
        Button btn3 = yourButton3.GetComponent<Button>();
        Button btn4 = yourButton4.GetComponent<Button>();
        Button btn5 = yourButton5.GetComponent<Button>();
        btn1.onClick.AddListener(Suma);
        btn2.onClick.AddListener(Diferenta);
       btn3.onClick.AddListener(Produs);
        btn4.onClick.AddListener(Impartire);
        btn5.onClick.AddListener(Modul);
    }
    void Suma()
    {
         t = x + y;
        text = Exit.GetComponent<Text>();
        text.text = t.ToString();
    }
    void Diferenta()
    {
        t = x - y;
        text = Exit.GetComponent<Text>();
        text.text = t.ToString();
    }
    void Produs()
    {
        t = x * y;
        text = Exit.GetComponent<Text>();
        text.text = t.ToString();
    }
    void Impartire()
    {
        t = x / y;
        text = Exit.GetComponent<Text>();
        text.text = t.ToString();
    }
    void Modul()
    {
        t = x % y;
        text = Exit.GetComponent<Text>();
        text.text = t.ToString();
    }
}
