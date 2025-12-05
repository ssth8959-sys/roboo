using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class towerslector : MonoBehaviour
{
    public List<GameObject> towers;
    public List<GameObject> towers2;
    GameObject maintower;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        towers = new List<GameObject>();
        towers2 = new List<GameObject>();
        towers = GameObject.FindGameObjectsWithTag("tower1").ToList();
        towers2 =GameObject.FindGameObjectsWithTag("tower2").ToList(); 
        maintower = towers[Random.Range(0, towers.Count - 1)];
        GameObject.Find("player1").GetComponent<BODY>().towers = towers2;
        GameObject.Find("player2").GetComponent<BODY>().towers = towers;
    }

    // Update is called once per frame
    void Update()
    {

        towers = towers.Where(x => x != null).ToList();

        if (maintower.GetComponent<towerhp>().currenthp <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
    //public void gameover(string name)
//    {
        
  //      {
  
  //      }
   // }
//}
