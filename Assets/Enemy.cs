using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject mc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(mc.transform);
		transform.Translate(transform.forward * 2 * Time.deltaTime);
	}
}
