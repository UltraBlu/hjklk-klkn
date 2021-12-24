using UnityEngine;
using System.Collections;

public class ThirdPersonCameraController : MonoBehaviour 
	{

	public float RotationSpeed = 10;
	public Transform gun, Player;
	float mouseX, mouseY;


	void Start (){

	}
	
	void LateUpdate ()
	{
		CamControl ();
	}

	void CamControl ()
	{
		mouseX += Input.GetAxis ("Mouse X") * RotationSpeed;
		mouseY -= Input.GetAxis ("Mouse Y") * RotationSpeed;
		mouseY = Mathf.Clamp (mouseY, -35, 60);


		transform.LookAt (gun);


		gun.rotation = Quaternion.Euler (mouseY, mouseX, 0);
		Player.rotation = Quaternion.Euler (0, mouseX, 0);
	}
}