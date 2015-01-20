using UnityEngine;
using System.Collections;
using Meta;

public class CombineMesh : MetaBehaviour {
	public GameObject parent;

	public void combine() {
		GameObject newparent = GameObject.CreatePrimitive (PrimitiveType.Cube);
		foreach (Transform child in parent.transform) {
			child.parent = newparent.transform;
			MetaBody mb = child.GetComponent<MetaBody>();
			if (mb) {
				mb.grabbable = false;
				mb.pinchable = false;
			}
		}

		newparent.transform.parent = parent.transform;
		newparent.AddComponent<MetaBody> ();
		MetaBody mb2 = newparent.GetComponent<MetaBody> ();
		mb2.grabbable = true;
		Destroy (newparent.GetComponent<MeshRenderer> ());
		newparent.name = "cuuuba";
	}
}
