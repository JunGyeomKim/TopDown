using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//装填
public class GunController : MonoBehaviour {

	public Transform weaponHold;

	public Gun startingGun;

	Gun equippedGun;
	public int ShootCount = 5;

	public 

	void Start()
	{
		UIManager.Instance.BULLET = ShootCount;

	
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			StopCoroutine("ProjectileReroad");
			SoundManager.instance.PlayReload();
			StartCoroutine("ProjectileReroad");
		}
	}



	public void Shoot()
	{
		if (ShootCount == 0)

		return;

			if (ShootCount <= 5)
			{
				ShootCount--;
				equippedGun.Shoot();
				UIManager.Instance.BULLET = ShootCount;
			}
	}

	IEnumerator ProjectileReroad()
	{
		yield return new WaitForSeconds(2.0f);
			ShootCount = 5;
		UIManager.Instance.BULLET = ShootCount;
	}
}
