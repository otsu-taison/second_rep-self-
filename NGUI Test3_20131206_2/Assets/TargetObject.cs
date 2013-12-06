using UnityEngine;
using System.Collections;

public class TargetObject : MonoBehaviour {

	//[HideInInspector]
	public GameObject buttonPosition;	//オブジェクト
	public GameObject buttonPrefab;		//プレハブ
	public GameObject buttonScene01;

	//private boolean isFading = false;
	//	float time = 0;

	void Start() {
		GameObject button = NGUITools.AddChild (buttonPosition, buttonPrefab) as GameObject;	//インスタンスの生成
		button.transform.localPosition = new Vector3(210.0f, 0, 0);								//位置の指定
		button.transform.localScale = new Vector3(1.0f, 4.0f, 1.0f);							//サイズの指定

		GameObject button2 = NGUITools.AddChild (buttonPosition, buttonPrefab) as GameObject;		//インスタンスの生成
		button2.transform.localPosition = new Vector3(420.0f, 0, 0);								//位置の指定
		button2.transform.localScale = new Vector3(1.0f, 4.0f, 1.0f);								//サイズの指定

		button.GetComponent<UIButtonMessage> ().target = buttonScene01;
		button.GetComponent<UIButtonMessage> ().functionName = "ClickTest";

		//	Destroy (button);
		TweenAlpha.Begin (button, 2.0f, 0);
//		TweenAlpha.Begin (button2, 2.0f, 0);
	}

//	void Update() {
//	//クリック
//		if(Input.GetMouseButtonDown(0)) {
//			Debug.Log ("click OK");
//			Application.LoadLevel("Scene02");
//			}
//	}


	void ClickTest () {
		Debug.Log ("button pressed!");
		Application.LoadLevel("Scene02");
	}
}
