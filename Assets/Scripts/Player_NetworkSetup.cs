using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;


public class Player_NetworkSetup : NetworkBehaviour {

	[SerializeField]
	private GameObject _camera;

	[SerializeField] 
	private PlayerDriver _PlayerDriver;

	[SerializeField]
	private BoxCollider2D _BoxCollider2D;

	// Use this for initialization
	void Start () {

			_camera.SetActive(isLocalPlayer);//isLocalPlayer возвращает true если объект прнадлежит локальной машине
			_PlayerDriver.enabled =  isLocalPlayer; //всеравно что true прописали
			_BoxCollider2D.enabled = isLocalPlayer;


	}
}