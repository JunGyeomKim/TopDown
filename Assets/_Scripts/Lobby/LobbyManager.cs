using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//ロビー実装
public class LobbyManager : MonoBehaviour
{
	public UIButton StartBtn;
	public UIButton HelpBtn;
	public UIButton ExitBtn;
	public UIButton HelpCloseBtn;
	Transform HelpClose;
	Transform HelpPopup;
	void Start ()
	{
		StartBtn.onClick.Add(new EventDelegate(OnClickStartBtn));
		HelpBtn.onClick.Add(new EventDelegate(OnClickHelpBtn));
		ExitBtn.onClick.Add(new EventDelegate(OnClickExitBtn));
		HelpCloseBtn.onClick.Add(new EventDelegate(OnClickHelpBtnClose));

		HelpPopup = transform.Find("HelpPopup");
		HelpClose = transform.Find("CloseBtn");
	}
	
	

	void OnClickStartBtn()
	{
		SceneManager.LoadScene("Stage1");
	}

	void OnClickHelpBtn()
	{
		HelpPopup.gameObject.SetActive(true);
	}

	void OnClickExitBtn()
	{
		Application.Quit();
	}

	void OnClickHelpBtnClose()
	{
		HelpPopup.gameObject.SetActive(false);
	}
}
