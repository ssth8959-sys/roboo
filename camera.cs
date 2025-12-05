using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;  
    public GameObject camera6;
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(count == 0)
            {
                camera1.SetActive(false);
                camera2.SetActive(true);
                count++;
            }
            else if(count == 1)
            {
                camera2.SetActive(false);
                camera3.SetActive(true);
                count++;
            }
            else if(count == 2)
            {
                camera3.SetActive(false);
                camera4.SetActive(true);
                count++;
            }
            else if(count == 3)
            {
                camera4.SetActive(false);
                camera5.SetActive(true);
                count++;
            }
            else if(count == 4)
            {
                camera5.SetActive(false);
                camera6.SetActive(true);
                count++;
            }
            else if(count == 5)
            {
                camera6.SetActive(false);
                camera1.SetActive(true);
                count = 0;
            }
       
           
        }
    }
}
