using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    Rigidbody rb;
    public GameObject cibic;
    public GameObject clone;
    Rigidbody rbCube;
    // Rigidbody rbCil;
    public GameObject cilinder;
    public GameObject sten;
    float score;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical * 10f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f, moveHorizontal* 5f,0f);
    }
    void OnCollisionEnter(Collision pop){
    //	if(pop.gameObject.tag == "capsule"){
     //   rbCube = cibic.GetComponent<Rigidbody>();
      //  rbCube.AddForce(transform.forward * 120f);
     //   }
      //  if(pop.gameObject.tag == "cilinder"){
     //   clone = Instantiate(cilinder,new Vector3(cilinder.transform.position.x,cilinder.transform.position.y, transform.position.z + 1), Quaternion.identity);
     //   score ++;
     //   print(score);
     //   }
     //   if(pop.gameObject.tag == "sten" && score>=5){
     //   sten.transform.position.y +1;
     //   }
    }
   
}
