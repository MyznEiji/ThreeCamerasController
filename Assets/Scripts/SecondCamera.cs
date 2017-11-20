using UnityEngine;
using DG.Tweening;

public class SecondCamera : MonoBehaviour 
{
	static public Tween secondTween;
	void Start () 
	{
		secondTween = transform.DOMove(new Vector3(0,2,2),7f)
				 .OnComplete(() =>
				 {
					 if(gameObject)CameraController.ChangeCamera(1);
				 });	
	}
}
