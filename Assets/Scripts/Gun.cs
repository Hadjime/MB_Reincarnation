using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public GameObject target;
	public GameObject bullet;
	private int direction;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Debug.Log (GameObject.Find ("Red_man_0").GetComponent<Rigidbody2D> ().transform.rotation.eulerAngles.z);
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			OnKeyCtrl ();
		}
	}

	void OnKeyCtrl()
	{
		GameObject newBullet = Instantiate (bullet);


		if (GameObject.Find ("Red_man_0").GetComponent<Rigidbody2D> ().transform.rotation.eulerAngles.z == 0)
		{
			//bullet.transform.position = new Vector2 (transform.position.x + 0.2f, transform.position.y);
			//newBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10, 0);

			//Debug.Log(transform.localPosition.y);
		}
		if (GameObject.Find ("Red_man_0").GetComponent<Rigidbody2D> ().transform.eulerAngles.z == 180)
		{
			//bullet.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y);
			//newBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-10, 0);
			//Debug.Log("Popali v uslovie");
		}
		if (GameObject.Find ("Red_man_0").GetComponent<Rigidbody2D> ().transform.eulerAngles.z == 90)
		{
			//bullet.transform.position = new Vector2 (target.transform.localPosition.x, target.transform.position.y);
			//newBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 10);
			//Debug.Log("Popali v uslovie");
		}
		if (GameObject.Find ("Red_man_0").GetComponent<Rigidbody2D> ().transform.eulerAngles.z == -90)
		{
			//bullet.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y);
			//newBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -10);
			//Debug.Log("Popali v uslovie");
		}
		Debug.Log (target.transform.position.y);

	}
}
