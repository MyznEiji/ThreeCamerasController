using UnityEngine;
using DG.Tweening;

public class FirstCamera : MonoBehaviour 
{	
	static public Tween firstTween;
		void Start () 
	{	
		firstTween = transform.DOMove(new Vector3(0,0,-2),7f)
				 .OnComplete(() => 
				 {
					 if(gameObject)CameraController.ChangeCamera(0);
				 });	
	}
}
