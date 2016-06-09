using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	public GameObject mc;

	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		if(Input.GetKey(KeyCode.Q)) {
			transform.RotateAround(mc.transform.position, new Vector3(0, 1, 0), -90 * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.E)) {
			transform.RotateAround(mc.transform.position, new Vector3(0, 1, 0), 90 * Time.deltaTime);
		}
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt(mc.transform);
	}
}
