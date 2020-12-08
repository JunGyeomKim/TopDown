using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour {

	Vector3 Velocity;
	Rigidbody myRigidBody;
	void Start()
	{
		myRigidBody = GetComponent<Rigidbody>();
	}


	public void Move(Vector3 _Velocity)
	{
		Velocity = _Velocity;
	}

	public void LookAt(Vector3 lookPoint)
	{
		Vector3 heightCorrectedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
		transform.LookAt(heightCorrectedPoint);
	}

	public void FixedUpdate()
	{
		myRigidBody.MovePosition(myRigidBody.position + Velocity * Time.fixedDeltaTime);
	}

	


}
