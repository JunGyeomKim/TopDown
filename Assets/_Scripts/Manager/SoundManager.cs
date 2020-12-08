using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//SoundManager
public class SoundManager : MonoBehaviour {

	public AudioClip Shoot;
	public AudioClip Reload;
	public AudioClip Meow;
	GameObject Sound;
	public static SoundManager instance;

	private void Awake()
	{
		if(SoundManager.instance == null)
		{
			SoundManager.instance = this;
		}
	}

	


	// Use this for initialization
	void Start ()
	{
		Sound = Resources.Load("Sound") as GameObject;
		//Sound = GetComponent<AudioSource>();
	}


	public void PlayerShoot()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source =  go.GetComponent<AudioSource>();

		source.clip = Shoot;
		source.volume = 0.5f;
		source.Play();
	}

	public void PlayReload()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();

		source.clip = Reload;
		source.Play();

	}

	public void PlayMeow()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();

		source.clip = Meow;
		//source.volume = 
		source.Play();
	}
}
