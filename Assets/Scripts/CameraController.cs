using UnityEngine;
using DG.Tweening;
public class CameraController : MonoBehaviour 
{
	[SerializeField] GameObject[] camerasObj = new GameObject[3];
	static GameObject[] cameras = new GameObject[3];
	static int count = 0;
	static float time ;
	void Start () 
	{
		cameras = camerasObj;
	}
	
	void Update () 
	{
		time += Time.deltaTime;
		if(Input.GetMouseButtonDown(0) && time >= 2.0 && count < 2)
		{
			if(count == 0)FirstCamera.firstTween.Kill();
			if(count == 1)SecondCamera.secondTween.Kill();
			ChangeCamera(count);
		}	
	}
	static public void ChangeCamera(int num)
	{
		cameras[num].SetActive(false);
		cameras[num + 1].SetActive(true);
		count ++;
		time = 0;
	}
}
