using System.Numerics;
using System.Threading;
using TMPro;
using UnityEngine;

public class emnyattackk : MonoBehaviour
{
    public GameObject target;
    public float dis;
    bool c;
    int count;
    GameObject emny;
    GameObject playeremnny; 
    public TMP_Text hppopup;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        emny = transform.parent.gameObject.GetComponent<enmy>().emny;
        playeremnny = transform.parent.gameObject.GetComponent<enmy>().playeremny;

        if (dis <= 2) {
            if (target == null) return;
            Debug.Log("attack");
            transform.LookAt(target.transform.position);
            transform.Translate(0, 0, 0.1f); }

        if (c)
        {
            count++;
        }
    
    }
    public void OnTriggerEnter(Collider o)
    {
        if ((o == emny))
        {
        o.gameObject.GetComponent<enmy>().damagedd("emnyattack");
            hppopup.text = "1";

        }
        if(o == playeremnny)
        {
            o.GetComponent<BODY>().damaged("emnyattack");
            hppopup.text = "1";
        }
        //çUåÇÇÃä‘äu
        gameObject.SetActive(false);

        c = true;
        if (count % 500 == 0)
        {
            gameObject.SetActive(true);
            c = false;
        }

    }
}
