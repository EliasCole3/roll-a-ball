using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
//		transform.Rotate(new Vector3(15, 30, 45));
//		transform.Rotate(new Vector3(15, 30, 45) * 0.01f);
	}
}
