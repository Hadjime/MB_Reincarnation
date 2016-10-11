using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public Animator animator;

	private float speed = 2;
	private float direction_x, direction_y; //направление
	private Rigidbody2D rb2d;
	float MoveHorizontal, MoveVertikal;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		direction_x = 0;
		direction_y = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (!Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.DownArrow) && !Input.GetKey (KeyCode.UpArrow)) {
			NoKeyDown ();
		}


		if (Input.GetKey (KeyCode.RightArrow)) {
			//Debug.Log (rb2d.velocity.y);
			OnKeyRigth();

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			//Debug.Log ("Left");
			OnKeyLeft();
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			//Debug.Log("UP");
			OnKeyUp();
		}

		if (Input.GetKey(KeyCode.DownArrow)){
			//Debug.Log ("DOWN");
			OnKeyDown();
		}

	
	}

	public void OnKeyRigth(){
		direction_x = 1;
		gameObject.transform.rotation = Quaternion.Euler (0, 0, 0); //варащение при помощи кватерниона
		//gameObject.transform.eulerAngles = new Vector3(0, 0, 0)//вращение как углы эйлера
		rb2d.velocity = new Vector2 (speed * direction_x, 0); // rb2d.velocity.y = 0 т.к. не изменяется направление по y

	}

	public void OnKeyLeft(){
		direction_x = -1;
		gameObject.transform.rotation = Quaternion.Euler (0, 0, 180); //варащение при помощи кватерниона
		//gameObject.transform.eulerAngles = new Vector3(0, 0, 180);//вращение как углы эйлера
		rb2d.velocity = new Vector2 (speed * direction_x, 0);
	}

	public void OnKeyUp(){
		direction_y = 1;
		gameObject.transform.rotation = Quaternion.Euler (0, 0, 90); //варащение при помощи кватерниона
		//gameObject.transform.eulerAngles = new Vector3 (0, 0, 90);//вращение как углы эйлера
		rb2d.velocity = new Vector2(0, speed * direction_y);
	}

	public void OnKeyDown(){
		direction_y = -1;
		gameObject.transform.rotation = Quaternion.Euler (0, 0, 270); //варащение при помощи кватерниона
		//gameObject.transform.eulerAngles = new Vector3 (0, 0, 270);//вращение как углы эйлера
		rb2d.velocity = new Vector2 (0, speed * direction_y);
	}

	void NoKeyDown(){
		/*if (rb2d.velocity.x == 0 & rb2d.velocity.y == 0) {
			animator.SetBool ("run", false);
			return;
		}*/
		//rb2d.velocity = new Vector2 (0, 0);
	}
}
