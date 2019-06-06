using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReColor : MonoBehaviour
{ 
	
private Color hoverColor = Color.red;
private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
    	renderer.material.color = hoverColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
