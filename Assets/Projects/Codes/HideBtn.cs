using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideBtn : MonoBehaviour {
	public Button PlayBtn;
	// Use this for initialization
	void Start () {
		PlayBtn.gameObject.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
