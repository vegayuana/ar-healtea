using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideFood : MonoBehaviour {
	public GameObject Food;
	// Use this for initialization
	void Start () {
		Food.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
