using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//プレイヤーの動きを実装
public class Player : MonoBehaviour
{
	public float moveSpeed = 5.0f;

	Camera viewCamera;
	PlayerControl controller;
	GunController gunController;

	float PlayerLife = 3;

	private void Start()
	{
		controller = GetComponent<PlayerControl>();
		gunController = GetComponent<GunController>();
		viewCamera = Camera.main;
		CreateManager.Instance.SetPlayer(transform);
	}

	private void Update()
	{
		Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		controller.Move(moveVelocity);

		Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);


		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

		float rayDistance;

		if (groundPlane.Raycast(ray, out rayDistance))

		{
			Vector3 point = ray.GetPoint(rayDistance);
			controller.LookAt(point);
		}

		if (Input.GetMouseButtonDown(0))
		{
			gunController.Shoot();
		}

	}

	

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "EnemyChaser")
		{
			PlayerLife--;
			Debug.Log(PlayerLife + "만큼 남았습니다.");
			UIManager.Instance.PlayerLife();
		}
		if (PlayerLife == 0)
		{
			Destroy(gameObject);
			Time.timeScale = 0;
		}
	}



}




