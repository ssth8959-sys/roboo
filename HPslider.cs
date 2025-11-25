using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HPslider : MonoBehaviour
{
    Slider slider2;
    Slider slider1;
    BODY player2;
    BODY player1;
    TMP_Text text2;
    TMP_Text text1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        slider2 = GameObject.Find("HPslider2").GetComponent<Slider>();
        player2 = GameObject.Find("player2").GetComponent<BODY>();
        slider1 = GameObject.Find("HPslider1").GetComponent<Slider>();
        player1 = GameObject.Find("player1").GetComponent<BODY>();
        text2 = GameObject.Find("hptext2").GetComponent<TMP_Text>();
        text1 = GameObject.Find("hptext1").GetComponent<TMP_Text>();

        slider2.maxValue = player2.MaxHP;
        slider1.maxValue = player1.MaxHP;
        Debug.Log(text2.text);
    }

    // Update is called once per frame
    void Update()
    {
        slider2.value = player2.currentHP;
        slider1.value = player1.currentHP;
        text2.text = player2.currentHP.ToString()+ "/" + player2.MaxHP.ToString();
        text1.text = player1.currentHP.ToString() + "/" + player1.MaxHP.ToString();
    }
}
