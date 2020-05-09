using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public int health = 12;
	[SerializeField]
	private NavMeshAgent agent;
	public TextMesh displayHealth; //Отображатель здоровья над головой врагов
	
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update()
	{
		//Взять у главной камеры позицию игрока
		agent.SetDestination(Camera.main.GetComponent<PropertiesScene>().player.position);
		
		if (health <= 0)
		{
			Destroy(gameObject);
		}
		
		displayHealth.text = "Health: "+health;
	}
}
