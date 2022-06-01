
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float moveSpeed;
	public GameObject mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera.transform.localPosition = new Vector3 ( 0, 1.3f, -40 );
		mainCamera.transform.localRotation = Quaternion.Euler (18, 180, 0);
	
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	
	
	
	
}























