using UnityEngine;

public class hp : MonoBehaviour
{
    public int maxhp;
    public int currenthp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxhp = 1000;
        currenthp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void damaged(string n)
    {
        Debug.Log(n);
        if (n == "bullet (Clone)")
        {
            currenthp -= 1;
            Debug.Log(currenthp);
        }
        else if( n == "hover(Clone)") 
        {
            currenthp -= 35;
        }
        else
        {
            //‰ñ”ð
            Debug.Log("!");
        }
    }
}
