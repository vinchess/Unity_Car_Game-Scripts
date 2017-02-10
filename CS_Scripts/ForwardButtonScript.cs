using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ForwardButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public Button brakeButton;
	public CarControlScript Car;

	void Start () {
		Button btn = brakeButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	public void OnPointerDown (PointerEventData eventData) 
	{
		Car.drive ();
	}

	public void OnPointerUp(PointerEventData eventData) 
	{
		Car.noDrive ();
	}

	void TaskOnClick(){
		//Car.drive ();
	}
}
