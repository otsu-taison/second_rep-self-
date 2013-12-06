using UnityEngine;
using System.Collections;

public class ButtonText : MonoBehaviour {

	private int i;
	private UILabel label;

	// Use this for initialization
	void Start () {

		label = GameObject.Find("Label(button2)").GetComponent<UILabel>(); 

//		for(i=0;i<3;i++) {
//
//			label = GameObject.Find("Label(button)"+ i + "").GetComponent<UILabel>(); 
//
//		}

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (i);
		label.text = "Count:" + 1.ToString ();

	}
}
