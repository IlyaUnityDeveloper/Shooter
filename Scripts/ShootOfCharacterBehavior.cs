using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт прикриплен к Character
public class ShootOfCharacterBehavior : MonoBehaviour
{
	void Start()
	{
		//Заблокировать курсор
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update()
    {
		//Выстрел
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
        if (Physics.Raycast(ray, out hit))
        {
			//Если объект, на который направлен луч является врагом
            if (hit.collider.gameObject.GetComponent<EnemyBehavior>())
			{
				//Отнять 4 единицы здоровье
				hit.collider.gameObject.GetComponent<EnemyBehavior>().TakeDamage(4);
			}
        }
    }
}
