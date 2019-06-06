using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveCubic : MonoBehaviour
{
    Rigidbody rb;
    public GameObject player;
    public GameObject bullet;
    GameObject cloneBull;
    Rigidbody rbClone;
    public Text txt;
    int hp = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    //    textt.GetComponent<Text>().text = 100;
    }
    void OnCollisionEnter(Collision trig)
     {   if(trig.gameObject.tag == "enemy"){
            hp = hp - 1;
            txt.text = "HP:" + hp;
            if (hp == 0){
            SceneManager.LoadScene(1);
            }
        } 
    }

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical * 50f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f, moveHorizontal* 5f,0f);

        if(Input.GetKeyDown("space")){   
            cloneBull = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            rbClone =  cloneBull.GetComponent<Rigidbody>();
            rbClone.AddForce(transform.forward * 300f);
          }
    }
}
