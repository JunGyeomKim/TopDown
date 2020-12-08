using System.Collections;
using System.Collections.Generic;
using UnityEngine;





//ハウスに侵入する猫の動き
public class EnemyMove : MonoBehaviour
{

	private const float CAT_SPEED = -5.0f;
	public Transform FishTarget = null;
	public Transform HouseTarget;



	public Transform TARGET
	{
		set
		{
			HouseTarget = value;
		}
	}



	void Update ()
	{
			Move();
	}
	
	void Move()
	{
		transform.position = 
			Vector3.Lerp(transform.position,
			HouseTarget.transform.position, Time.deltaTime*0.2f);

		Vector3 dir = HouseTarget.transform.position - transform.position;
		this.transform.rotation =
			Quaternion.Lerp(
				this.transform.rotation,
				Quaternion.LookRotation(dir),
				Time.deltaTime * 10);

	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			Destroy(other.gameObject);
		}
	}


	







}
