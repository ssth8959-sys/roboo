using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;


public class fly : MonoBehaviour
{
    public GameObject target;
    public GameObject wepon;
    GameObject tama;
    string namee;
    float speed;
    float speedd;
    int count;
    int count2;
    string targetname;
    Collider tamacollider;
    Collider [] weponcollider;
    public TMP_Text hppopup;
    List<GameObject> emnys;
    List<GameObject> emnys2;
    public float minnn = 9999;
    List<GameObject> all;
   
    // Start is called once befquore the first execution of Update after the MonoBehaviour is created

    public void OnTriggerEnter(Collider other)
    {
        if (wepon.name == "player2")
        {
            
            if (other.CompareTag("emny2"))
            {
                Physics.IgnoreCollision(other, tamacollider);

            }
        }
        if (wepon.name == "player1")
        {
            if (other.CompareTag("emny1"))
            {
                Physics.IgnoreCollision(other, tamacollider);

            }
        }



        Destroy(gameObject);
            Debug.Log("ok");
            BODY v = other.GetComponent<BODY>();
        enmy vv = other.GetComponent<enmy>();

        
            //BODY v = other.gameObject.GetComponent<BODY>();
            if (v != null)
        
            {
                v.damaged(namee);
            if (namee == "hover(Clone)") {
                //hppopup.GetComponent<>
                hppopup.text =  GameObject.Find("player1").GetComponent<BODY>().hoverdamage.ToString(); ;
                Instantiate(hppopup, other.transform.position, quaternion.identity);
                
                
            
            }
            if(namee == "bullet (Clone)")
            {
                hppopup.text = GameObject.Find("player1").GetComponent<BODY>().bulletdamage.ToString();
                Instantiate(hppopup, other.transform.position, quaternion.identity);
            }
                //Debug.Log(namee);
            }
        if (vv != null)
        {
            vv.damagedd(namee);
            if (namee == "hover(Clone)")
            {
                //hppopup.GetComponent<>
                hppopup.text = GameObject.Find("emny1(Clone)").GetComponent<enmy>().hoverdamage.ToString(); ;
                Instantiate(hppopup, other.transform.position, quaternion.identity);


            }
            if (namee == "bullet (Clone)")
            {
                hppopup.text = GameObject.Find("player1").GetComponent<BODY>().bulletdamage.ToString();
                Instantiate(hppopup, other.transform.position, quaternion.identity);
            }
            //Debug.Log(namee);
        }

    }
    void Start()

    {
        
        tamacollider = GetComponent<Collider>();
        weponcollider = wepon.GetComponentsInChildren<Collider>();
        foreach(Collider col in weponcollider)
        {
            Physics.IgnoreCollision(col, tamacollider); 
        }
        
        all = new List<GameObject>();

        tama = this.gameObject;
        namee = tama.name;

        //Debug.Log("111111" + namee);
        speed = 0.0000000000000000000000000001f;
        speedd = 0.00020000f;

        //target = GameObject.Find("player2");
        //transform.LookAt(target.transform);
        //targetname =  target.name;

        


    }

    // Update is called once per frame
    void Update()

    {








        if (target != null)
        {
            transform.LookAt(target.transform);
        }
                

        
        

        if (namee == "bulle)") 
        {
            Debug.Log("flyyyy");
                }
        
        switch (namee)
        {
            case "bullet (Clone)":
                int rate = UnityEngine.Random.Range(0, 10);
                float rate2  = UnityEngine.Random.Range(0f, 1f);
                if (rate == 0) 
                {
                    transform.Translate(0, 1f, 1f);
                }
                else if(rate < 1) 
                {
                    transform.Translate(0, rate2, rate2);
                }
                else {
                    transform.Translate(0, 0, 1f);
                    Destroy(gameObject, 1);
                }
           
                break;

            case "hover(Clone)":
                count += 1;



                if (target != null)
                {
                    if (count >= 400 && count < 450)
                    {
                        //Debug.Log("over 100");
                        transform.Translate(0, 0.1f, 0);
                    }
                    if (count >= 450)
                    {
                        transform.LookAt(target.transform);
                        transform.Translate(0, 0, speed);
                        speed += speedd;
                        speedd += 0.000000000000001f; 
                        Destroy(gameObject, 4);
                    }
                }






                break;
                

                    }




                }


     }
      
    