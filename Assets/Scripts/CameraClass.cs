﻿using UnityEngine;
using System.Collections;

public class CameraClass : MonoBehaviour 
{
	
	public  float moveRate = 2.0f; 
	public GameObject screenBoundsWest;
	public GameObject screenBoundsEast; 
	public GameObject screenBoundsNorth; 
	public GameObject screenBoundsSouth; 
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		/// <summary>
    	/// Allows for mouse position to move the camera, and has bounds on the corners. 
    	/// </summary>
		
		if(Input.mousePosition.x >(Screen.width - Screen.width/10) && !screenBoundsEast.renderer.isVisible)
		{
			transform.position = new Vector3(transform.position.x + moveRate * Time.deltaTime, transform.position.y, transform.position.z); 
		}
		if(Input.mousePosition.x < Screen.width/10 && !screenBoundsWest.renderer.isVisible)
		{
			 transform.position = new Vector3(transform.position.x - moveRate * Time.deltaTime, transform.position.y, transform.position.z); 
			
		}
		
		if(Input.mousePosition.y >(Screen.height - Screen.height/10) && !screenBoundsNorth.renderer.isVisible)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z+ moveRate * Time.deltaTime); 
		}
		
		if(Input.mousePosition.y < Screen.height/10 && !screenBoundsSouth.renderer.isVisible)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z - moveRate * Time.deltaTime); 
		}

	}
}
