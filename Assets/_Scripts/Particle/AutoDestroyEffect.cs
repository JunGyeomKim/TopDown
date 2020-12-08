using System.Collections;
using System.Collections.Generic;
using UnityEngine;





//オブジェクトのパーティクルシステム
public class AutoDestroyEffect : MonoBehaviour
{
	ParticleSystem particle;

	void Start()
	{
		particle = GetComponent<ParticleSystem>();
	}
	void Update()
	{
		if(particle.isPlaying == false)
		{
			Destroy(gameObject);
		}
	}
	
}
