using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public AudioClip back;
	public AudioClip letgo;
	private GameObject ally;
	void Start()
	{
		ally = GameObject.Find ("Ally");
	}
	void OnControllerColliderHit(ControllerColliderHit col) 
	{
		if(col.gameObject.tag.Equals("Tree"))
			print ("Cuidado! ai tem uma arvore!");
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag.Equals ("Way")) 
		{
			ally.GetComponent<Animator>().enabled = true;
			ally.GetComponent<AudioSource>().clip = letgo;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag.Equals ("Way")) 
		{
			ally.GetComponent<Animator> ().enabled = false;
			ally.GetComponent<AudioSource> ().enabled = true;
			ally.GetComponent<AudioSource>().clip = back;
			ally.GetComponent<AudioSource>().Play();
		}
	}

	void Update()
	{
	}
}
