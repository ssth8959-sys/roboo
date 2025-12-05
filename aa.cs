using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class aa : MonoBehaviour
{
    public GameObject Bullet;
    GameObject flyy;
    public GameObject target;
    string tama;
    public List<GameObject> tamalist;
    int count;
    string me;
    enum wepons { bullet, misail, lazer, hover };
    wepons wepon;
    //List<GameObject> emnys;
    //List<GameObject> emnys2;
    public float minnn;
    GameObject min;
    List<GameObject> bullets;
    public bool t;
    public AudioClip bulletaudio;
    public AudioClip hoveraudio;
    public AudioSource audioSource;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // emnys = new List<GameObject>();
        //emnys2 = new List<GameObject>();

        
        //Debug.Log(tama);
        me = transform.root.gameObject.name;

        bullets = new List<GameObject>();
        for (int i = 0; i < 1; i++)
        {
            int a = UnityEngine.Random.Range(0, tamalist.Count );
            tama = tamalist[a].name.Trim().ToLower();
            Bullet = tamalist[a];
        }
        if (tama == "bullet")
        {
            wepon = wepons.bullet;
        }
        else if (tama == "misail")
        {
            wepon = wepons.misail;
        }
        else if (tama == "hover")
        {
            wepon = wepons.hover;
        }
        else
        {
            wepon = wepons.lazer;
        }


        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()

    {//emnys = emnys.Where(x  => x != null).ToList();

        //GameObject allive1 = GameObject.Find("player1");
        //GameObject allive2 = GameObject.Find("player2");




     

        
            if (minnn < 25f)
            {
                count += 1;
                switch (wepon)
                {
                    case wepons.bullet:


                        if (count % 120 == 0)
                        {
                        audioSource.PlayOneShot(bulletaudio);

                            if (target == null)
                            {

                            }


                        if (target == null) return; //デバック
                            flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                     
                        fly f = flyy.GetComponent<fly>();
                        
                        f.wepon = transform.root.gameObject;
                            f.target = target;
                            f.minnn = minnn;
                        f.on = true;
                        transform.LookAt(target.transform);

                        }
                        break;
                    case wepons.hover:

                        if (count % 750 == 0)
                        {
                            if (target == null)
                            {

                            }
                        audioSource.PlayOneShot(hoveraudio);
                        flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                  
                      
                        fly f = flyy.GetComponent<fly>();
                            f.wepon = transform.root.gameObject;
                            f.target = target;
                        f.on = true;
                        if (target == null) return;
                            transform.LookAt(target.transform);
                        }
                        break;
                    case wepons.misail:
                        if (count % 150 == 0)
                        {
                            flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                            fly f = flyy.GetComponent<fly>();
                            f.wepon = transform.root.gameObject;
                            f.target = target;
                        f.on = true;
                            if (target == null) return; transform.LookAt(target.transform);


                        }
                        break;

                }

            }











        }
    }


    

