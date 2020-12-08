using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ハウスと猫の衝突処理とスコア計算
public class House : MonoBehaviour
{

	float HouseLife = 3.0f;

	private void Start()
	{
		CreateManager.Instance.SetHouse(transform);
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cat")
		{
			HouseLife--;
			UIManager.Instance.LifeCountFunc();
			Destroy(other.gameObject);

		}
		if (HouseLife == 0)
		{
			Time.timeScale = 0;
		}

		if (other.gameObject.tag == "Bullet")
		{
			Destroy(other.gameObject);
		}

		
	}
}
