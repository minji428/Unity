using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class GameResult_CSharp : MonoBehaviour {
	private int highScore;
	public Text resultTime;
	public Text bestTime;
	public GameObject parts;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("HighScore")){
			highScore = PlayerPrefs.GetInt("HighScore");
		}else{
			highScore = 999;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalArea_CSharp.goal){
			parts.SetActive(true);
			int result = Mathf.FloorToInt(Timer_CSharp.time);
			resultTime.text = "ResultTime " + result;
			bestTime.text = "BestTime " + highScore;
			
			if(highScore > result){
				PlayerPrefs.SetInt("HighScore",result);
			}
		}
	}

   public void OnRetry(){
		Application.LoadLevel("Main");
	} 
}
