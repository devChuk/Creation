using UnityEngine;
using System.Collections;
using Meta;

public class CopyFunction : MetaBehaviour {
	public Object copyObject;
	public GameObject render;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Copy() {
		//Debug.Log("yoswaggaswagga");
		GameObject clone = Instantiate (copyObject) as GameObject;//GameObject.Find ("THECUBE")) as GameObject;
		clone.SetActive (true);

		clone.transform.parent = render.transform;
	}

	public void resetFunc() {
		Debug.Log ("P1");
		
		Debug.Log ("P2");
	}
}
