using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт прикриплен к EnemiesSpawner
public class EnemiesSpawner : MonoBehaviour
{
    public Rect spawnerArea = new Rect(-5f, -5f, 5f, 5f); //Предел области в которой будут создаваться враги
	public GameObject enemy;
	
	void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
	
	//Каждые 3 секунды создает нового врага в пределах определенной области
	IEnumerator SpawnEnemy()
    {
        while (true)
		{
			yield return new WaitForSeconds(10);
			Instantiate(enemy, new Vector3(Random.Range(spawnerArea.x, spawnerArea.width), 1, Random.Range(spawnerArea.y, spawnerArea.height)), Quaternion.identity);
		}
    }
}
