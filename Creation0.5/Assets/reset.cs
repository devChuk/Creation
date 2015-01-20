using UnityEngine;
using System.Collections;
using Meta;

public class reset : MetaBehaviour {
	public Object pointer;
	public double x1, y1, x2, y2;
	// Use this for initialization
	void Start () {
		x1 = 0;
		y1 = 0;
		x2 = 0;
		y2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void resetFunc() {
		// Debug.Log ("P1");
		// Debug.Log (Meta.Hands.right.pointer.position.x);
		// Debug.Log (Meta.Hands.right.pointer.position.y);
		// Debug.Log ("P2");
	}
}
