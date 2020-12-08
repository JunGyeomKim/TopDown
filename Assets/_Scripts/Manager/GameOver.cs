using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//ゲーム・オブ・時ScoreUI生成
public class GameOver : MonoBehaviour
{ 
	int score;
	public int SCORE
	{
		get
		{
			return score;
		}
		set
		{
			score = value;
		}
	
	}

	public Text CatCountText;
	public Text BulletText;
	public Text LifeText;
	public Text EnemyChaserText;

	public Text ScoreText;

	void Update ()
	{
	if(Time.timeScale == 0)
		{
			CallUIManager();
		}
	}


	public void CallUIManager()
	{
		CatCountText.text = UIManager.Instance.CatCount.ToString();
		BulletText.text = UIManager.Instance.BulletCount.ToString();
		LifeText.text = UIManager.Instance.LifeCount.ToString();
		EnemyChaserText.text = UIManager.Instance.EnemyChaserCount.ToString();


		ScoreText.text = ((UIManager.Instance.CatCount + 
			UIManager.Instance.LifeCount + 
			UIManager.Instance.EnemyChaserCount * 2 )-
			UIManager.Instance.BulletCount).ToString();
	}

	
}
