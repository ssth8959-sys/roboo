using UnityEngine;

public class startt : MonoBehaviour
{
    int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
            if(count % 2000 == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
