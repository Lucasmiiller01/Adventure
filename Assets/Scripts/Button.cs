using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	public GameObject player;
	public string direction;
	public void OnPointerDown (PointerEventData eventData) 
	{
		if(direction.Equals("UP"))
			player.GetComponent<FPSInputController>().SendMessage("Up");
		else if(direction.Equals("DOWN"))
			player.GetComponent<FPSInputController>().SendMessage("Down");
		else if(direction.Equals("LEFT"))
			player.GetComponent<MouseLook>().SendMessage("Left");
		else if(direction.Equals("RIGHT"))
			player.GetComponent<MouseLook>().SendMessage("Right");


	}
	public void OnPointerUp(PointerEventData eventData) 
	{
		if(direction.Equals("UP") ||direction.Equals("DOWN"))
			player.GetComponent<FPSInputController>().SendMessage("Null");
		if(direction.Equals("LEFT") || direction.Equals("RIGHT"))
			player.GetComponent<MouseLook>().SendMessage("Null");
	}
}