using UnityEngine;
using System.Collections;

public class BadGuy : MonoBehaviour {
	public GameObject myControl;
	public float mySpeed = 3f;
	public GameObject myBullet;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (myControl.GetComponent<EnemyController> ().left == true) {
			moveLeft ();
		}
		else if (myControl.GetComponent<EnemyController> ().right == true) {
			moveRight ();
		}
		else if (myControl.GetComponent<EnemyController> ().down == true) {
			moveDown ();
		}
		if (Random.Range (0, myControl.GetComponent<EnemyController> ().EnemiesLeft * 60) == 1) {
			Instantiate(myBullet, this.transform.position, Quaternion.identity);
		}
	}
	void moveLeft(){
		this.rigidbody.velocity = new Vector3 (-mySpeed, 0, 0);
	}
	void moveRight(){
		this.rigidbody.velocity = new Vector3 (mySpeed, 0, 0);
	}
	void moveDown(){
		this.rigidbody.velocity = new Vector3 (0, 0, -mySpeed);
	}
	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "wall") {
			if (myControl.GetComponent<EnemyController> ().left == true) {
				myControl.GetComponent<EnemyController> ().left = false;
				myControl.GetComponent<EnemyController> ().next = "Right";
				myControl.GetComponent<EnemyController> ().down = true;
			}
			if (myControl.GetComponent<EnemyController> ().right == true){
				myControl.GetComponent<EnemyController> ().right = false;
				myControl.GetComponent<EnemyController> ().next = "Left";
				myControl.GetComponent<EnemyController> ().down = true;
			}
		}
		if (collision.gameObject.tag == "barrier") {
			Application.Quit ();
		}
	}
}
