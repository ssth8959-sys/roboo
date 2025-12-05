using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class textcontoll : MonoBehaviour
{
    public TMP_Text skill1;
    public TMP_Text skill2;
    public TMP_Text skill3;
    public TMP_Text skill11;
    public TMP_Text skill22;
    public TMP_Text skill33;
    public TMP_Text namee;
    public GameObject player1;
    public GameObject player2;


    List<string> ssskills1;
    List<string> ssskills2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(stat.named1);
        GameObject.Find("name1").GetComponent<TMP_Text>().text = newww.getname1(1);
        GameObject.Find("name2").GetComponent<TMP_Text>().text = newww.getname1(2);
        Debug.Log(GameObject.Find("name1").GetComponent<TMP_Text>().text + "text");
         //TMP_Text skill1 = GameObject.Find("skill1").GetComponent< TMP_Text>();
         //TMP_Text skill2 = GameObject.Find("skill2").GetComponent<TMP_Text>();
       // TMP_Text skill3 = GameObject.Find("skill3").GetComponent<TMP_Text>();
          //TMP_Text skill11;
     //TMP_Text skill22;
     //TMP_Text skill33;


    ssskills1 = new List<string>();
        ssskills2 = new List<string>();


        ssskills1 = player1.GetComponent<BODY>().sskills;
        ssskills2  = player2.GetComponent<BODY>().sskills;



    }

    // Update is called once per frame
    void Update()
    {

        UpdateSkillDisplay();

    }

    void UpdateSkillDisplay()
    {

        if (skill1 != null)
        {
            if (ssskills1.Count >= 1)
            {
                skill1.text = ssskills1[0];
            }
            else
            {
                skill1.text = "empty";
            }
        }


        if (skill2 != null)
        {
            if (ssskills1.Count >= 2)
            {
                skill2.text = ssskills1[1];
            }
            else
            {
                skill2.text = "empty";
            }
        }


        if (skill3 != null)
        {
            if (ssskills1.Count >= 3)
            {
                skill3.text = ssskills1[2];
            }
            else
            {
                skill3.text = "empty";
            }
        }
        if (skill11 != null)
        {
            if (ssskills2.Count >= 1)
            {
                skill11.text = ssskills2[0];
            }
            else
            {
                skill11.text = "empty";
            }
        }


        if (skill22 != null)
        {
            if (ssskills2.Count >= 2)
            {
                skill22.text = ssskills2[1];
            }
            else
            {
                skill22.text = "empty";
            }
        }


        if (skill33 != null)
        {
            if (ssskills2.Count >= 3)
            {
                skill33.text = ssskills2[2];
            }
            else
            {
                skill33.text = "empty";
            }
        }
    }
}




