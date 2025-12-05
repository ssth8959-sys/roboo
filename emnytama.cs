using System.Collections.Generic;
using UnityEngine;

public class emnytama : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        death();
    }
    public class deathemny
    {
        public GameObject g;
        public bool c;
        public int deathtime;
    }

    List<deathemny> waiting = new List<deathemny>();

    public void deathdata(GameObject a, bool b)
    {
        waiting.Add(new deathemny
        {
            g = a,
            c = b,
            deathtime = 0
        });



    }

    public void death()
    {
        foreach (var i in waiting)

        {
            if (i.c)
            {
                i.g.SetActive(false);
                i.deathtime++;
            }

            if (i.deathtime % 500 == 0 && !i.g.activeInHierarchy)
            {
                i.g.transform.position = i.g.transform.root.transform.position;
                i.g.SetActive(true);
                if (i.g.name == "player1")
                {

                    i.c = false;
                    i.deathtime = 0;
                }

            }
        }
    }
}
