using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer_CSharp : MonoBehaviour {
	public static float time;

	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalArea_CSharp.goal == false){
			time += Time.deltaTime;
		}
		int t = Mathf.FloorToInt(time);
		Text uiText = GetComponent<Text>();
		uiText.text = "Time :" + t.ToString();

	}
}
