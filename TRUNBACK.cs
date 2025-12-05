using UnityEngine;

public class TRUNBACK : MonoBehaviour
{
    GameObject TOWER1;
    GameObject TOWER2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TOWER1 = GameObject.Find("tower");
        TOWER2 = GameObject.Find("tower2");
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player1")
        {

            other.transform.position = TOWER1.transform.position;
            if (other.gameObject.name == "player2")
            {
                other.transform.position -= TOWER2.transform.position;
            }
        }
    }
}
