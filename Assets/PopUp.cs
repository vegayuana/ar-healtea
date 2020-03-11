using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Vuforia;

public class PopUp : MonoBehaviour {
	public GameObject window;
	int counter;

	// Show	
	// Displays the indicated message in a pop-up window
	public void Show() {		
		window.gameObject.SetActive (true);
	}

	// Hide
	//Close the pop-up window

	public void Hide () {
		window.gameObject.SetActive (false);
	}

	//show hide pop-up window
	public void showHide (){
		counter++;
		if (counter % 2 == 1) {
			window.gameObject.SetActive (true);
		}  
		else {			
			window.gameObject.SetActive (false);
		}
	}
}