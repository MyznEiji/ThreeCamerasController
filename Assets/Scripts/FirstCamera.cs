using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FirstCamera : MonoBehaviour 
{
	void Start () 
	{
		transform.DOLocalMove(new Vector3(0,0,-2f),5f);
	}
	
	//void Update () 
	//{
	//	
	//}
}
