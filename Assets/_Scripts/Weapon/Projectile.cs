using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//弾丸の移動速度と衝突処理
public class Projectile : MonoBehaviour
{
	public GameObject CatParticle;
	public GameObject EnemyChaserParticle;
	public Vector3 ParticleRotation;


	float speed = 10f;
	static public bool a;


	public void SetSpeed(float newSpeed)
	{
		speed = newSpeed;
	}
	void Update()
	{
		float moveDistance = speed * Time.deltaTime;
		transform.Translate(Vector3.forward * moveDistance);
	}



	private void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "Cat")
		{
			Destroy(other.gameObject);
			UIManager.Instance.CatCountFunc();
			SoundManager.instance.PlayMeow();
			if(CatParticle != null)
			{
				Instantiate(CatParticle, 
					other.transform.position,Quaternion.Euler(ParticleRotation));
			}
		}

		if (other.gameObject.tag == "EnemyChaser")
		{
			
			Destroy(other.gameObject);
			UIManager.Instance.EnemyChaserCountFunc();
			if(EnemyChaserParticle!= null)
			{
				Instantiate(EnemyChaserParticle, 
					other.transform.position, Quaternion.Euler(ParticleRotation));

			}
		}

		
	}
}

	
