using UnityEngine;
using UnityEngine.UI;

public class sliderHP : MonoBehaviour
{
    Slider slider;
    Slider slider2;
    BODY player1;
    hp player2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GameObject.Find("HPslider1").GetComponent<Slider>(); 
        slider2 = GameObject.Find("HPslider2").GetComponent<Slider>();
        player1 = GameObject.Find("player1").GetComponent<BODY>();
        player2 = GameObject.Find("player2").GetComponent<hp>();
        Debug.Log("HP:" + player2.currenthp);
        //slider.maxValue = player1.MaxHP;
        slider2.maxValue = player2.maxhp;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HP:e" + player2.currenthp);
        Debug.Log("value:" + slider2.value);

        //slider.value = player1.currentHP;
        slider2.value = player2.currenthp;
        
    }
}
