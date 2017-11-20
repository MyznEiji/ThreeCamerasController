using UnityEngine;
using DG.Tweening;
public class CameraController : MonoBehaviour 
{
	[SerializeField] GameObject[] camerasObj = new GameObject[3];
	static GameObject[] cameras = new GameObject[3];
	static int chacngeCameraCount = 0;
	static float changeCameraTime = 0f;
	void Start () 
	{
		cameras = camerasObj;
		print("画面をクリックすると次のカメラビューに移ります。");
	}
	
	void Update () 
	{
		changeCameraTime += Time.deltaTime;
		if(Input.GetMouseButtonDown(0) && changeCameraTime >= 2.0 && chacngeCameraCount < 2)
		{
			if(chacngeCameraCount == 0)FirstCamera.firstTween.Kill();
			ChangeCamera(chacngeCameraCount);
		}	
	}
	static public void ChangeCamera(int num)
	{
		cameras[num].SetActive(false);
		cameras[num + 1].SetActive(true);
		chacngeCameraCount ++;
		changeCameraTime = 0;
	}
}
