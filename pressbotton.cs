using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class preassbotton : MonoBehaviour
{
    List<GameObject> name;
    List<GameObject> namee;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name = new List<GameObject> ();
        namee = new List<GameObject> ();
        name = GameObject.FindGameObjectsWithTag("name").ToList();

        foreach(GameObject i in name)
        {
            namee.Add(i);


            i.SetActive(false); ;
        }
        Debug.Log("okk");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            Debug.Log("ok");
            GameObject.Find("press").SetActive(false);
            Debug.Log("ok1");
            name = GameObject.FindGameObjectsWithTag("name").ToList();
            Debug.Log("ok2");

            namee[0].SetActive(true);
            namee[1].SetActive(true);
           
          gameObject.SetActive(false);
        }   
    }
}
