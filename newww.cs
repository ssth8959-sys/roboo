using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class newww : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_InputField input2;
    protected static string namee;
    protected static string namee2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        namee = input.text;
        namee2 = input2.text;
    }

    public static string getname1(int a)
    {
        
        if (a == 1)
        {
            return namee;
        }
        if (a == 2)
        {
            return namee2;
        }
        else
        {
            return "null";
        }
    }
}

