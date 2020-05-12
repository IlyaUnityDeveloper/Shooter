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
	[SerializeField]
	private Transform player;
	
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		displayHealth.text = "Health: "+health;
		player = Camera.main.GetComponent<PropertiesScene>().player;
	}
	
	void Update()
	{
		//Взять у главной камеры позицию игрока
		agent.SetDestination(player.position);
	}
	
	public void TakeDamage (int damage)
	{
		health -= damage;
		
		if (health <= 0)
		{
			Destroy(gameObject);
		}
		
		displayHealth.text = "Health: "+health;
	}
}
