using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ReverseButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler  {

	public Button brakeButton;
	public CarControlScript Car;

	public void OnPointerDown (PointerEventData eventData) 
	{
		Car.reverse ();
	}

	public void OnPointerUp(PointerEventData eventData) 
	{
		Car.noReverse ();
	}
}
