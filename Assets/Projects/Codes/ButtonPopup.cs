using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;

public class ButtonPopup : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour mTrackableBehaviour;
	
	private bool mShowGUIButton = false;
	public Button PlayButton;
	public UnityEngine.UI.Image Intro;
	
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
	}
	
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
    }
	
	void OnGUI() {
		if (mShowGUIButton) {
			PlayButton.gameObject.SetActive (true);
			Intro.gameObject.SetActive(true);
		}
		else{
			PlayButton.gameObject.SetActive (false);
			Intro.gameObject.SetActive(false);
		}
		
	}
}