using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallChek : MonoBehaviour {
	private PlayerControl player;
	private List<Collider2D> colliderList = new List<Collider2D> ();
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Red_man_0").GetComponent<PlayerControl> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		//if(collider.tag == "Wall_down")
		//{
			//colliderList.Add(collider);
			Debug.Log("Stena!!!! NIJNAYA");
			//player.OnKeyLeft();
		//}
	}
}
