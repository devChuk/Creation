using UnityEngine;
using Meta;
using System.Collections;

public class drawrect : MetaBehaviour {
	public Object box;
	public GameObject render, GUI;
	public double x1, y1, x2, y2;
	public int timesPressed, extruding;// Either 1 or 2 

	// Use this for initialization
	void Start () {
		x1 = 0;
		y1 = 0;
		x2 = 0;
		y2 = 0;
		timesPressed = 0;
		extruding = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//public void reallyStopExtrude() {extruding = 0;}
	public void stopExtrude() {
		extruding = 0;
		//drawrect other = GUI.GetComponent (drawrect) as drawrect;
		// Call the function DoSomething on the script
		//other.reallyStopExtrude ();
	}

	public void Draw() {
		if (timesPressed == 0 && extruding == 0) {
			x1 = Meta.Hands.right.pointer.position.x;
			y1 = Meta.Hands.right.pointer.position.y;
			++timesPressed;
		} else if (extruding == 0) {
			extruding = 1;
			x2 = Meta.Hands.right.pointer.position.x;
			y2 = Meta.Hands.right.pointer.position.y;
			timesPressed = 0;
			// now we draw
			GameObject clone = Instantiate (box) as GameObject;//GameObject.Find ("THECUBE")) as GameObject;
			clone.SetActive (true);
			Vector3 tempPos = clone.transform.position;
			tempPos.x = (float)x1;
			tempPos.y = (float)y1;
			tempPos.z = 0;
			Vector3 tempPos2 = clone.transform.position;
			tempPos2.x = (float)x2;
			tempPos2.y = (float)y2;
			tempPos2.z = 0;
			clone.transform.parent = render.transform;
			//now we reshape

			clone.transform.localScale = new Vector3(System.Math.Abs(tempPos2.x - tempPos.x),System.Math.Abs((tempPos2.y - tempPos.y)/2),0);
			//renderer.bounds.size

		}
	}
}
