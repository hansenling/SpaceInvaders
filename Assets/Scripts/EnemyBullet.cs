using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	public float bulletspeed = 5f;
	// Use this for initialization
	void Start () {
		this.renderer.material.color = new Vector4 (1f, 0f, 0f, 1f);
		this.rigidbody.velocity = new Vector3 (0f, 0f, -bulletspeed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "barrier" ) {
			Destroy (collision.gameObject);
			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "wall") {
			Destroy (this.gameObject);	
		}

	}
}
