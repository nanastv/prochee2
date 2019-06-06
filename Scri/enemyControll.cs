using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyControll : MonoBehaviour
{
    NavMeshAgent enemy;
    public Transform posit;
    public Text ttxx;
    static int score = 0;

    void Start()
    {
    	//posit = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        enemy = GetComponent<NavMeshAgent>();
    }
        void OnCollisionEnter(Collision trig)
     {   
         if(trig.gameObject.tag == "bullet"){
          Destroy(gameObject);
          score = score + 1;
          ttxx.text = "Score:" + score;
          if(score == 4){
          SceneManager.LoadScene(1);
          }
        } 
    }
    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(posit.position);
    }
}
