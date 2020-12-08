using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






//UIManager 
public class UIManager : MonoBehaviour
{
	private static UIManager instance;
	public static UIManager Instance
	{
		get
		{
		return instance;
		}
	}
	
	int CurrBullet;

	public int BULLET
	{
		get
		{
			return CurrBullet;
		}
		set
		{
			CurrBullet = value;
		}
	}

	public Text CatCountText;
	public Text EnemyChaserText;
	public Text BulletText;
	public Text LifeText;
	public Text WarningText;
	public Text PlayerLifeText;
	public Text CurrBulletText;

	public int CatCount;
	public int EnemyChaserCount;
	public int BulletCount;
	public int LifeCount;
	public int PlayerLifeCount = 3;

	Transform GameOver;
	
	private void Start()
	{
		instance = this;
		GameOver = transform.Find("GameOver").GetComponent<Transform>();
		GameOver.gameObject.SetActive(false);
	}




	private void Update()
	{
		CurrBulletCount();
		if(Time.timeScale == 0)
		{
			GameOver.gameObject.SetActive(true);
		}
	}

	public void CatCountFunc()
	{
		CatCount++;
		CatCountText.text = CatCount.ToString();
	}

	public void EnemyChaserCountFunc()
	{
		EnemyChaserCount++;
		EnemyChaserText.text = EnemyChaserCount.ToString();
	}

	public void BulletCountFunc()
	{
		BulletCount++;
		BulletText.text = BulletCount.ToString();
	}

	public void LifeCountFunc()
	{
		LifeCount++;
		LifeText.text = LifeCount.ToString();
	}


	public void PlayerLife()
	{
		PlayerLifeCount--;
		PlayerLifeText.text = PlayerLifeCount.ToString();
	}

	public void CurrBulletCount()
	{
		CurrBulletText.text = CurrBullet.ToString();
	}

	
}