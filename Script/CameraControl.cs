using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraControl : MonoBehaviour
{
    Rigidbody rb;
    public GameObject bull ;
    int score = 0;
    GameObject cloneBull;
    Rigidbody rbClone;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision trig)
     {   if(trig.gameObject.tag == "Cube"){
            Destroy(trig.gameObject);
            print("Hello CUBE"); 
            score = score - 1;
            print(score);
          } 
         else if(trig.gameObject.tag == "Sphere"){
            Destroy(trig.gameObject);
            print("Hello SPHERE"); 
            score++;
            print(score);
          } 
          if(score >= 2 && trig.gameObject.tag == "door"){
                Destroy(trig.gameObject);
          }
          if(trig.gameObject.tag == "stena"){
                Destroy(gameObject);
            }
            else if(trig.gameObject.tag == "win"){
                Destroy(trig.gameObject);
                print("YOU WIN!");
            }
     }
    // Update is called once per frame
    void Update()
    {   // движение вперёт назад
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical * 50);
        // повороты
        float moveHor = Input.GetAxis("Horizontal");
        transform.Rotate(0,moveHor * 10,0);

        if(Input.GetKeyDown("space")){   
        cloneBull = Instantiate(bull, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        cloneBull.GetComponent<Rigidbody>();
        rbClone.AddForce(transform.forward * 50);

        }
    }
}
