using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class EatFood : MonoBehaviour {
	
	public GameObject food;
	public List<GameObject> FoodList = new List<GameObject>();
	private int ranTemp=0;
	public Text score;
	public List<UnityEngine.UI.Image> HeartList = new List<UnityEngine.UI.Image>();
	private int heart=3;
	public Button PlayAgain, PlayWAC, EatBtn, ThrowBtn;
	public UnityEngine.UI.Image ScoreScreen;
	
	void Start() {
		food.gameObject.SetActive(true);
	}
	
	public void Eat(){
		//Convert UI Text to Int
		int scoreTemp = int.Parse(score.text);
		
		//Point Counts
		if(ranTemp<15){
			scoreTemp+=50;
		}
		else{
			losesHeart();
		}
		score.text = scoreTemp.ToString();
		nextFood();
	}
	
	private void nextFood(){
		//Max range of food
		int limit = FoodList.Count-1;
		//Generate next food
		int ran = Random.Range(0,limit);
		while(ran == ranTemp){
			ran = Random.Range(0,limit);
		}
		ranTemp = ran;
		//Hide last food
		food.gameObject.SetActive(false);
		food = FoodList[ran];
		//Show next food
		food.gameObject.SetActive(true);
	}
	
	private void losesHeart(){
		if(heart<=3 && heart>0){
			HeartList[heart-1].gameObject.SetActive(false);
			heart--;
		}
		if (heart==0){
			EatBtn.gameObject.SetActive(false);
			ThrowBtn.gameObject.SetActive(false);
			PlayAgain.gameObject.SetActive(true);
			PlayWAC.gameObject.SetActive(true);
			ScoreScreen.gameObject.SetActive(true);
			score.transform.position = new Vector3(595,320,0);
			//score.transform.position = new Vector3(985,500,0);
			score.fontSize = 200;
		}
	}
	
	public void Dont(){
		//Max range of food
		int limit = FoodList.Count-1;
		
		//Convert UI Text to Int
		int scoreTemp = int.Parse(score.text);
		//Point Counts
		if(ranTemp<15){
			scoreTemp-=30;
		}
		score.text = scoreTemp.ToString();
		nextFood();
	}
	
}
