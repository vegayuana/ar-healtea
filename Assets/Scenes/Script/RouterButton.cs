using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouterButton : MonoBehaviour {
	public void LoadScene(string scenename){
		Application.LoadLevel(scenename);
	}
}
