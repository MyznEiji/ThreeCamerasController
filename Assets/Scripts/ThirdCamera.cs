using UnityEngine;
using DG.Tweening;

public class ThirdCamera : MonoBehaviour 
{
	void Start () 
	{
		transform.DOMove(new Vector3(0,2,0),7f);	
	}
}
