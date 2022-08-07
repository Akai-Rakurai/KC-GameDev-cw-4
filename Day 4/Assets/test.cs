using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public int price = 5;
    public int score = 0;
    public int increment = 1;
    public Text text;
    public Text text2;
    public Text text3;
    public Text text4;
    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
        text2.text = increment.ToString();
        text3.text = "Cost = " + price;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increasescore()
    {
        score += increment;
        text.text = score.ToString();
    }
    public void store()
    {
        if (score >= price)
        {
            increment++;
            text2.text = increment.ToString();
            score -= price;
            price = price * 2;
            text3.text = "Cost = " + price;
            text.text = score.ToString();
            text4.text = "";
        }
        else
        {
            text4.text = "You don't have enough cookies.";
        }

    }

}
