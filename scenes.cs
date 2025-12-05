using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public scenes game;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void start()
    {
        SceneManager.LoadScene("1");
    }
}
