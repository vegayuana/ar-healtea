using UnityEngine;
using System.Collections;
using Vuforia;
public class AnimatorLoop1 : MonoBehaviour {
	Animation[] animations;

	void Start()	{		
		animations = (Animation[])Animation.FindObjectsOfType(typeof(Animation));		
		foreach(Animation a in animations) {			
			a.wrapMode = WrapMode.Loop;		
		}	
	}
}