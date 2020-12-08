using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyGun : MonoBehaviour
{


	// ロビーでの合計の動き
	void Update ()
	{
		transform.Rotate(Vector3.up * Time.deltaTime * 50.0f);
		transform.Rotate(Vector3.forward * Time.deltaTime * 50.0f);
		transform.Rotate(Vector3.left * Time.deltaTime * 50.0f);
		transform.Rotate(Vector3.right * Time.deltaTime * 50.0f);
	}
}
