using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
{
		   {
			if (Input.GetKeyDown ("space")) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 5, 0);
		   }
	}
}
}