using UnityEngine;
using DG.Tweening;

public class ThirdCamera : MonoBehaviour 
{
	void Start () 
	{
		transform.DOMove(new Vector3(0,20,0),7f)					 
				 .OnComplete(() => 
				 {
				  	print("終わりです。");
				 });
	}
}
