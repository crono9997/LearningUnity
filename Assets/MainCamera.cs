using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	public GameObject mc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt(mc.transform);
	}
}
