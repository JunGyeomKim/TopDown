using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//すべてのオブジェクトの作成と管理
public class CreateManager : MonoBehaviour
{
	//singleton
	private static CreateManager instance;
	public static CreateManager Instance
	{
		get
			{
			return instance;
			}
	}

	public GameObject OriginCat = null;
	public GameObject OriginFish = null;
	public GameObject OriginEnemyChaser = null;
	public GameObject OriginItem;

	Transform player = null;
	Transform house = null;


	GameObject newCat;
	GameObject newFish;
	GameObject newEnemyChaser;
	

	
	public List<EnemyMove> Chase = new List<EnemyMove>();


	//SpawnPoint
	public Transform Point1;
	public Transform Point2;
	public Transform Point3;
	public Transform Point4;
	
	
	private void Awake()
	{
		instance = this;
	}


	void Start()
	{
		StartCoroutine(Createobject());
		InvokeRepeating("CreateEnemyChaser", 5, 3);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			CreateFish();
		}
	}

	void CreateCat(Transform trans)
	{
		newCat = Instantiate(OriginCat,trans.position,trans.rotation);
		
		Chase.Add(newCat.GetComponent<EnemyMove>());


		newCat.GetComponent<EnemyMove>().TARGET = house.transform;
		
	}

	public void CreateFish()
	{
		newFish = Instantiate(OriginFish);
		newFish.transform.position = new Vector3(Random.Range(-8, 8), 1f, Random.Range(-8, 8));
		StartCoroutine(destroyobject(newFish));
		
		
		}


	public void CreateEnemyChaser()
	{
		newEnemyChaser = Instantiate(OriginEnemyChaser);
		newEnemyChaser.transform.position = 
			new Vector3(
				Random.Range(-8, 8),
				Random.Range(1, 3),
				Random.Range(-8, 8));
		if (player.transform == null)
			return;
		else
		newEnemyChaser.GetComponent<EnemyChaserMove>().TARGET = player.transform;
	}

	//Fish 소멸을 위한 코루틴

	IEnumerator destroyobject(GameObject go)
	{
		yield return new WaitForSeconds(3.0f);
		Destroy(go.gameObject);
	}

	IEnumerator Createobject()
	{
		
		while(true)
		{
			yield return new WaitForSeconds(5.0f);
			CreateCat(Point1);
			CreateCat(Point2);
			CreateCat(Point3);
			CreateCat(Point4);

		}
		


		// yield return null;이 항상 생략되어있다라고 생각하라고 규호가 시킴
	}

	

	public void SetPlayer(Transform trans)
	{
		player = trans;
		
	}
	public void SetHouse(Transform trans)
	{
		house = trans;
	}

	
	
}


	
	
		
