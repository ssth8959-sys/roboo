using System.Numerics;
using System.Threading;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class emnyattackk : MonoBehaviour
{
    public GameObject target;
    public float dis;
    bool c;
    int count;
    public GameObject emny;
    public GameObject playeremnny;
    public TMP_Text hppopup;
    int cc;
    int ccc = 0;
    UnityEngine.Vector3 tt;
    Collider co;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        co = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        emny = transform.parent.gameObject.GetComponent<enmy>().emny;
        playeremnny = transform.parent.gameObject.GetComponent<enmy>().playeremny;

        if (dis <= 2)
        {
            if (target == null) return;
            ;
           
            //Debug.Log("attack");
            tt = transform.position;
            UnityEngine.Vector3 vecc = target.transform.position - transform.position;
            transform.position += vecc.normalized * 3f * Time.deltaTime;
            cc++;
            if (cc % 900f == 0)
            {
                co.enabled = false;
                transform.position = tt;
                if (transform.position == tt)
                {
                    co.enabled = true;
                }


            }
       
        }
        
        if (ccc % 900f == 0)
        {
            co.enabled = false;
            transform.position = tt;
            if (transform.position == tt)
            {
                co.enabled = true;
            }


        }



        //if (c)
        //{
          //  count++;
          //
           // if (count % 500 == 0)
            //{
              //  gameObject.SetActive(true);

                //c = false;
      //      }

        //}
        

    }
    public void OnTriggerEnter(Collider o)
    {
        
        Component a = o.gameObject.GetComponent<BODY>();
        if (o.CompareTag("emny1") || o.CompareTag("emny2"))
        {

            if (transform.root.name == "emny2(Clone)")
            {

                if (o.CompareTag("emny2"))
                {
                    Physics.IgnoreCollision(o, GetComponent<Collider>());

                }
            }
            if (transform.root.name == "emny1(Clone)")
            {

                if (o.CompareTag("emny1"))
                {
                    Physics.IgnoreCollision(o, GetComponent<Collider>());

                }
            }
            if ((o.gameObject == emny))
            {
                o.gameObject.GetComponent<enmy>().damagedd("emnyattack");
                hppopup.text = "1";
                Instantiate(hppopup, transform.position, quaternion.identity);

            }
            
            var hitBody = o.GetComponentInParent<BODY>();
            if (hitBody != null)
            {
             
                if (hitBody.gameObject == playeremnny)
                {
                    hitBody.damaged("emnyattack");
                    Debug.Log("playerattack");
                    if (hppopup != null) Instantiate(hppopup.gameObject, transform.position, quaternion.identity);
                    return;
                }
            }
            else if (o.gameObject == playeremnnyÅ@)
            {
                o.gameObject.GetComponent<BODY>().damaged("emnyattack");
                Debug.Log("playerattack");
                hppopup.text = "1";
                Instantiate(hppopup, transform.position, quaternion.identity);
            }
            //çUåÇÇÃä‘äu
            // GameObject.Find("emnytama").GetComponent<emnytama>().deathdata(this.gameObject, true);



        }
    }
}
