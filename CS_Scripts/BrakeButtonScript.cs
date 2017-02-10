using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class BrakeButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler   {

	public Button brakeButton;
	public CarControlScript Car;

	public void OnPointerDown (PointerEventData eventData) 
	{
		Car.brake ();
	}

	public void OnPointerUp(PointerEventData eventData) 
	{
		Car.noBrake ();
	}
}
