using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    public GameObject Quaq_1, Quad_2;
    public int x = 0, y = 500, z = 0;
    string s1 = "Hello World!";
    public Text IncTxt, DecTxt, HelloTxt;
    void Start()
    {
        Debug.Log("Hello World!");  

    }
    void FixedUpdate()
    {
        if (x <= 500)
        {
            x++;
        }
        if (y >= 0)
        {
            y--;
        }
        if (z == 0)
        {
            HelloTxt.text += s1[0].ToString();

        }
        if (z <= 550)
        {
            z++;
        }

        if (x % 50 == 0 && x <= 500)
        {
            IncTxt.text = (x / 50).ToString();
        }

        if (y % 50 == 0 && y >= 0)
        {
            DecTxt.text = (y / 50).ToString();
        }

        if (z % 50 == 0 && z <= 550 && z / 50 != 5)
        {
            HelloTxt.text += s1[z / 50].ToString();
        }
        else if (z / 50 == 5 && z < 550)
        {
            HelloTxt.text += s1[5].ToString();
            HelloTxt.text += s1[6].ToString();
            z += 50;
        }

        if (x > 500)
        {
            Quaq_1.SetActive(false);
            Quad_2.SetActive(false);
        }
    }
 }
