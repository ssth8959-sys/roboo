using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{
   
    public TMP_InputField input;
    protected static string name1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
     input = GetComponent<TMP_InputField>();    
    }

    // Update is called once per frame
    void Update()
    { 
        setname1();
       //if(gameObject.name == "input1")
        //{
       
        //}
        //if (gameObject.name == "input2")
        //{
          //  stat.named2 = input.text;
        //}




    }
    public void setname1()
    {
      name1       = input.text;
    }
    public static string getname1() { 
    return name1;
    }


}
