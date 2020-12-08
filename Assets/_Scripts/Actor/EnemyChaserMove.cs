using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//プレーヤーを追跡する追跡者の動き
public class EnemyChaserMove : MonoBehaviour
{
	public Transform PlayerTarget;
	public Transform TARGET
	{
		set
		{
			PlayerTarget = value;
		}
	}


	private void Update()
	{
		if(PlayerTarget != null)
		{
		transform.position = Vector3.Lerp(
			transform.position,
			PlayerTarget.transform.position, 
			Time.deltaTime);
		}
	}

	


}
