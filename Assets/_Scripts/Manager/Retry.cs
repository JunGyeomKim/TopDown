using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




//再起動のためのロゴロード
public class Retry : MonoBehaviour
{
	Transform a;
	public void TaskOnClick()
	{
		a = transform.parent;
		a.gameObject.SetActive(false);
		SceneManager.LoadScene("Lobby");
	}

}
