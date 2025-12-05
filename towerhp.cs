using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class towerhp : MonoBehaviour
{
    Slider hpbar;
    public Canvas canvas;
    public int currenthp ;
    int maxhp = 800;
    public int bulletdamage = 1;
    public int hoverdamage = 8;
    List<GameObject> towershp = new List<GameObject>();
    public Slider towerhpbar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenthp = maxhp;

       Instantiate(canvas, transform.position + new Vector3(0,3,0), Quaternion.identity);
        towerhpbar = canvas.transform.Find("towarbar").gameObject.GetComponent<Slider>();
        towerhpbar.maxValue = maxhp;
      
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        towerhpbar.value = currenthp;
        if (currenthp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
        
    
   
          public void damaged(string n)
    {
        
        if (n == "bullet (Clone)")
        {
            currenthp -= bulletdamage;
            //Debug.Log(currentHP);
        }
        else if (n == "hover(Clone)")
        {
            currenthp -= hoverdamage;
        }
        else
        {
            //‰ñ”ð
            Debug.Log("!");
        }
    }
}
