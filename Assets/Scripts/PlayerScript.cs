using UnityEngine;
using DG.Tweening;

public class PlayerScript : MonoBehaviour 
{
	void Start () 
	{
		transform.DOLocalPath 
				 (
					 new Vector3[]
					 {
						 new Vector3(-10f,0f,0f),
						 new Vector3(0f,0f,10f),
						 new Vector3(10f,0f,0f),
						 new Vector3(0f,0f,-10f)
					 },
					 10f,
					 PathType.CatmullRom
				 )
				 .SetLookAt (0.1f, Vector3.forward)
				 .SetEase (Ease.Linear)
				 .SetLoops(-1);
	}
}
