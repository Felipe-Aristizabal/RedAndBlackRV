using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Components;
using UniRx;

namespace ViewModel
{
	
	public class GameRoullete : ScriptableObject
	{
		public GameObject sphere;
		[Range(0,1000)] public float defaultSpeed = 0;
		public float currentSpeed;

		public ISubject<int> OnNumber = new Subject<int>();
		public ISubject<bool> OnRotate = new Subject<bool>();
	}
}
