using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class towerslector : MonoBehaviour
{
    List<GameObject> towers;
    GameObject maintower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        towers = new List<GameObject>();
        towers = GameObject.FindGameObjectsWithTag("tower1").ToList();
        maintower = towers[Random.Range(0, towers.Count-1)];
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameover(string name)
    {
        if (maintower.GetComponent<towerhp>().currenthp <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
        {

        }
    }
}
