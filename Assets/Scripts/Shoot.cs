using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullet;
	public float cooldown = 1f;
	static float myTimer = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && (myTimer > cooldown)) {
			Vector3 bulletSpawn = this.transform.position;
			bulletSpawn.z +=.2f;
			Instantiate(bullet, bulletSpawn, Quaternion.identity);
			myTimer = 0f;
		}
		myTimer += Time.deltaTime;

	}
}
