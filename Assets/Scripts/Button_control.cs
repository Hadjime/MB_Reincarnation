using UnityEngine;
using System.Collections;

public class Button_control : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDrag()
	{
		if (name == "Button_left")
		{
			GameObject.Find("Red_man_0").GetComponent<PlayerControl>().OnKeyLeft();
			//Debug.Log("knopla left");
		}
		if (name == "Button_right")
		{
			GameObject.Find("Red_man_0").GetComponent<PlayerControl>().OnKeyRigth();
			//Debug.Log("knopla left");
		}
		if (name == "Button_up")
		{
			GameObject.Find("Red_man_0").GetComponent<PlayerControl>().OnKeyUp();
			//Debug.Log("knopla left");
		}
		if (name == "Button_down")
		{
			GameObject.Find("Red_man_0").GetComponent<PlayerControl>().OnKeyDown();
			//Debug.Log("knopla left");
		}
	}

}
