using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WaveController : MonoBehaviour
{
	public void InitializeWave(int num)
	{
		Hero.S.speed -= .01f * num;
		
		//Enemy_1.S.speed 
	}
	
}
