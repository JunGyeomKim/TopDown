using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//発射された弾丸の破壊
public class DestroyBullet : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
			Destroy(other.gameObject);
	}
}
