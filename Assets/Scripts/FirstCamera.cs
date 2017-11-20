using UnityEngine;
using DG.Tweening;

public class FirstCamera : MonoBehaviour 
{	
	[SerializeField]private AnimationCurve customEasing;
	static public Sequence firstTween;
		void Start () 
	{	
		firstTween = DOTween.Sequence();
		firstTween = firstTween.Append
		(
			transform.DOMove(new Vector3(0,15,-2),7f)
					 .OnComplete(() => 
					 {
						 CameraController.ChangeCamera(0);
					 })
		);	
		
		
		firstTween.Join
		(
			transform.DORotate(new Vector3(60f,0,0),7f)
						.SetEase(customEasing)
		);
	}
}
