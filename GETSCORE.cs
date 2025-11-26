using Mono.Cecil.Cil;
using TMPro;
using UnityEngine;

public class GETSCORE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {if (GameObject.Find("player1") != null)
        {
            GameObject.Find("SCORE1").GetComponent<TMP_Text>().text = GameObject.Find("player1").GetComponent<BODY>().score.ToString();
        }
     if( GameObject.Find("player2") != null) {
            GameObject.Find("SCORE2").GetComponent<TMP_Text>().text = GameObject.Find("player2").GetComponent<BODY>().score.ToString(); }

    }
}
