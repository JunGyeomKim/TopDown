using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDestroy : MonoBehaviour
{

	// サウンド破壊
	void Start ()
	{
		StartCoroutine("SelfDestroy");
	}
	

	IEnumerator SelfDestroy()
	{
		yield return new WaitForSecondsRealtime(5.0f);
		Destroy(this.gameObject);
	}
}
