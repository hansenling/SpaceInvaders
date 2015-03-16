using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.rigidbody.velocity = new Vector3 (0, 0, 15);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "badguy" || collision.gameObject.tag == "barrier" ) {
			if (collision.gameObject.tag == "badguy"){
				collision.gameObject.GetComponent<BadGuy>().myControl.GetComponent<EnemyController>().EnemiesLeft -=1;
			}
			Destroy (collision.gameObject);
			Destroy (this.gameObject);

		}
		if (collision.gameObject.tag == "wall") {
			Destroy (this.gameObject);	
		}
	}
}
