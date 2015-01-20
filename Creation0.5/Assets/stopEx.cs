using UnityEngine;
using System.Collections;
using Meta;

public class stopEx : MetaBehaviour {
	public drawrect drawReckt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void plsStopEx() {
		//drawReckt = GetComponent<drawrect> ();
		drawReckt.stopExtrude();
	}
}
