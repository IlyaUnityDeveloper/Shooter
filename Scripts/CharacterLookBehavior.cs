using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт прикриплен к Character
public class CharacterLookBehavior : MonoBehaviour
{
    [SerializeField]
	private Vector3 currentAngleOfView; //Куда смотрит персонаж
	public float speedOfRotateX = 5.0f; //Скорость поворота камеры по горизонтали
	public float speedOfRotateY = 5.0f; //Скорость поворота камеры по вертикали
	
	void Update()
	{
		//Поворот камеры
		currentAngleOfView.x = currentAngleOfView.x - Input.GetAxis("Mouse Y") * speedOfRotateX;
		currentAngleOfView.y = currentAngleOfView.y + Input.GetAxis("Mouse X") * speedOfRotateY;
		
		//Ограничение угола наклона камеры по вертикали
		if (currentAngleOfView.x < -89f)
		{
			currentAngleOfView.x = -89f;
		}
		
		if (currentAngleOfView.x > 89f)
		{
			currentAngleOfView.x = 89f;
		}
		
		transform.rotation = Quaternion.Euler (currentAngleOfView.x, currentAngleOfView.y, 0);
	}
}
