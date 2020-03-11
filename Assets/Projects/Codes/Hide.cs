using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour {
	public UnityEngine.UI.Image Img;
	// Use this for initialization
	void Start () {
		Img.gameObject.SetActive(false); 		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
