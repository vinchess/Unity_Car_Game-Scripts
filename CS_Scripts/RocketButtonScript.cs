using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RocketButtonScript : MonoBehaviour {

	public Button rocketButton;

	void Start () {
		Button btn = rocketButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		GameObject HUD = GameObject.Find ("ScreenText");
		Text text = HUD.GetComponent<Text>();
		text.text = "FIRE!";
	}

}
