using UnityEngine;

public class life : MonoBehaviour
{
    int deathcount;
    public bool c;
    public bool c2;
    public GameObject g;
    public GameObject g2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (c)
        {
            g.SetActive(false);
            deathcount++;
            if (deathcount % 40000 == 0)
            {
                g.GetComponent<BODY>().currentHP = g.GetComponent<BODY>().MaxHP;
                g.SetActive(true);
                c =Å@false;
            }
        }

        if (c2)
        {
            g.SetActive(false);
            deathcount++;
            if (deathcount % 40000 == 0)
            {
                g.GetComponent<BODY>().currentHP = g2.GetComponent<BODY>().MaxHP;
                g.SetActive(true);
                c = false;
            }
        }









    }
}
 
