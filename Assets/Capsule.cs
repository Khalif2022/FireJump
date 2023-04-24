using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float speed = 0.1f;
	private Vector3 newposition;
	public KeyCode upKey = KeyCode.I;
	public KeyCode downKey = KeyCode.K;
	public KeyCode leftKey = KeyCode.J;
	public KeyCode rightKey = KeyCode.L;
	public KeyCode upKeyAlt = KeyCode.I;
	public KeyCode downKeyAlt = KeyCode.K;
	public KeyCode leftKeyAlt = KeyCode.J;
	public KeyCode rightKeyAlt = KeyCode.L;
	
	// Start is called before the first frame update
     
    
        

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition=transform.position;
		
		// Movement
		
		if (Input.GetKey(upKey)|| Input.GetKey(upKeyAlt))
		{	
			newposition.y+=speed;
			transform.position=newposition;
		}
		if (Input.GetKey(downKey)|| Input.GetKey(downKeyAlt))
		{
			newposition.y-=speed;
			transform.position=newposition;
		}
		if (Input.GetKey(leftKey)|| Input.GetKey(leftKeyAlt))
	    {
			
			newposition.x-=speed;
			transform.position = newposition;
		}
		if (Input.GetKey(rightKey)|| Input.GetKey(rightKeyAlt))
	    {
		
		newposition.x+=speed;
		transform.position = newposition;
		}
	}	
	
	
	{
		
}