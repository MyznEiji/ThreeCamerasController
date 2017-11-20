using System.Collections;
using UnityEngine;
using DG.Tweening;

public class SecondCamera : MonoBehaviour 
{
	[SerializeField] private Transform secondCameraTarget;
	IEnumerator Start()
	{
		yield return new WaitForSeconds(7f);
		CameraController.ChangeCamera(1);

	}
	void Update()
	{
		transform.position = secondCameraTarget.position;
		transform.rotation = secondCameraTarget.rotation;
	}
}
