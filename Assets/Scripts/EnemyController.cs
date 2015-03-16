using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public bool left = false;
	public bool right = true;
	public bool down = false;
	public string next = "Left";
	public float downTimer = 1f;
	public int EnemiesLeft = 50;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (down == true) {
			downTimer -= Time.deltaTime;
			if (downTimer <= 0){
				down = false;
				if (next == "Left"){
					left = true;
				}
				if (next == "Right"){
					right = true;
				}
				downTimer = 1f;
			}
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

}
