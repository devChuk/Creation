using UnityEngine;
using System.Collections;
using Meta;

public class pinch : MetaBehaviour {
	public float pointerLocation, firstpointer;
	public GameObject plank;

	//bad coding practice to always use public btw don't judge me

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPinch() {
		firstpointer = (float)Meta.Hands.right.pointer.position.z;
	}

	public void OnPinchHold() {
		pointerLocation = (float)Meta.Hands.right.pointer.position.z;
		plank.transform.localScale = new Vector3(plank.transform.localScale.x,plank.transform.localScale.y, firstpointer - pointerLocation);
	}
}
