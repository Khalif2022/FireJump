using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	public float speed = 0.1f;
	private Vector3 newposition;
	public KeyCode upKey = KeyCode.W;
	public KeyCode downKey = KeyCode.S;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;
	public KeyCode upKeyAlt = KeyCode.W;
	public KeyCode downKeyAlt = KeyCode.S;
	public KeyCode leftKeyAlt = KeyCode.A;
	public KeyCode rightKeyAlt = KeyCode.D;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newposition=transform.position;  
	 // newposition.y-=speed;
//	  transform.position=newposition;
	  // Movement
	  
	  if (Input.GetKey(upKey)|| Input.GetKey(upKeyAlt))
	  {
		  
		  newposition.y+=speed;
		  transform.position= newposition;
	  }
	  if  (Input.GetKey(downKey)|| Input.GetKey(downKeyAlt))
	  {
	       
		   newposition.y-=speed;
		   transform.position = newposition;
	  }	
	  if  (Input.GetKey(leftKey)|| Input.GetKey(leftKeyAlt))
	  {  
	       
		   newposition.x-=speed;
		   transform.position = newposition;
	  }
	  if   (Input.GetKey(rightKey)|| Input.GetKey(rightKeyAlt)) 
	  {   
	        
			newposition.x+=speed;
			transform.position = newposition;
	  }	
	}	  
}    
    
	

