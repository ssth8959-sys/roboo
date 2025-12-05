using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;


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
    public bool on = false;
    public AudioClip bulletaudio;
    public AudioClip hoveraudio;
    public AudioSource audio;
    public GameObject hovereffect, bulleteffect;

   
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
        if(other.name == "bullet(Bullet)")
        {
            Physics.IgnoreCollision(other, tamacollider);
        }




        Destroy(gameObject);
            
            BODY v = other.GetComponent<BODY>();
        enmy vv = other.GetComponent<enmy>();
        towerhp vvv =  other.GetComponent<towerhp>();


        //BODY v = other.gameObject.GetComponent<BODY>();
        if (v != null)

        {

            if (namee == "hover(Clone)") {
                //hppopup.GetComponent<>
                hppopup.text = GameObject.Find("player1").GetComponent<BODY>().hoverdamage.ToString();
                Instantiate(hppopup, transform.position, quaternion.identity);
                Instantiate(hovereffect, transform.position, quaternion.identity);
                if (v.currentHP > 0)
                {
                    v.damaged(namee);
                }
            } 
       




            if (namee == "bullet (Clone)")
            {
                hppopup.text = GameObject.Find("player1").GetComponent<BODY>().bulletdamage.ToString();
                Instantiate(hppopup, transform.position, quaternion.identity);
                Instantiate(bulleteffect, transform.position, quaternion.identity);
                if (v.currentHP > 0)
                {
                    v.damaged(namee);
                }

                
            }
                //Debug.Log(namee);
         }
        if (vv != null)
        {
            
            if (namee == "hover(Clone)")
            {
                if (other.name == "emny2(Clone)")
                {
                    hppopup.text = GameObject.Find("emny2(Clone)").GetComponent<enmy>().hoverdamage.ToString(); ;
                    Instantiate(hppopup, other.transform.position, quaternion.identity);
                    Instantiate(hovereffect, transform.position, quaternion.identity);
                    if (vv.currentHP > 0)
                    {
                        vv.damagedd(namee);
                    }
                }
                if(other.name == "emny1(Clone)")
                {
                    hppopup.text = GameObject.Find("emny1(Clone)").GetComponent<enmy>().hoverdamage.ToString(); ;
                    Instantiate(hppopup, other.transform.position, quaternion.identity);
                    Instantiate(hovereffect, transform.position, quaternion.identity);

                    if (vv.currentHP > 0)
                    {
                        vv.damagedd(namee);
                    }

                }


            }
            if (namee == "bullet (Clone)")
            {
                if (other.name == "emny2(Clone)")
                {
                    hppopup.text = GameObject.Find("emny2(Clone)").GetComponent<enmy>().bulletdamage.ToString();
                    Instantiate(hppopup, other.transform.position, quaternion.identity);
                    Instantiate(bulleteffect, transform.position, quaternion.identity);
                    if (vv.currentHP > 0)
                    {
                        vv.damagedd(namee);
                    }
                }
                if (other.name == "emny1(Clone)")
                {
                    hppopup.text = GameObject.Find("emny1(Clone)").GetComponent<enmy>().bulletdamage.ToString();
                    Instantiate(hppopup, other.transform.position, quaternion.identity);
                    Instantiate(bulleteffect, transform.position, quaternion.identity);
                    if (vv.currentHP > 0)
                    {
                        vv.damagedd(namee);
                    }
                }

         
            }
            //Debug.Log(namee);
        }

        if (vvv != null)

        {

            if (namee == "hover(Clone)")
            {
                //hppopup.GetComponent<>
                hppopup.text = "8";
                Instantiate(hppopup, other.transform.position, quaternion.identity);
                Instantiate(hovereffect, transform.position, quaternion.identity);
                if (vvv.currenthp > 0)
                {
                    vvv.damaged(namee);
                }

            }
            if (namee == "bullet (Clone)")
            {
                hppopup.text = "1";
                Instantiate(hppopup, other.transform.position, quaternion.identity);
                Instantiate(bulleteffect, transform.position, quaternion.identity);
                if (vvv.currenthp > 0)
                {
                    vvv.damaged(namee);
                }
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

        audio = GetComponent<AudioSource>();

        //target = GameObject.Find("player2");
        //transform.LookAt(target.transform);
        //targetname =  target.name;

        


    }

    // Update is called once per frame
    void Update()

    {






        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        if (target != null)
        {
            transform.LookAt(target.transform);
        }
                

        
        
        //íeÅAî≠éÀ
        if (namee == "bulle)") 
        {
            Debug.Log("flyyyy");
                }
        
        switch (namee)
        {
            case "bullet (Clone)":
              
                if (target == null)
                {
                    //Destroy(gameObject);
                }
                int rate = UnityEngine.Random.Range(0, 10);
                float rate2  = UnityEngine.Random.Range(0f, 0.5f);
                float rate3 = UnityEngine.Random.Range(1f , 1f);
                if (rate == 0) 
                {
                    transform.Translate(0, 0.5f, 0.5f);
                    Destroy(gameObject, 0.5f);
                }
                else if(rate <= 3) 
                {
                    transform.Translate(0, rate2, rate2);
                    Destroy(gameObject, 0.5f);
                }
                else {
                    transform.Translate(0, 0,rate3);
                    Destroy(gameObject, 0.5f);
                }
           
                break;

            case "hover(Clone)":
                
                count += 1;
                if (target == null)
                {
                    Destroy(gameObject);
                }



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
      
    