using UnityEngine;
using System.Collections;

public class ButtonTextChange : MonoBehaviour {

	private UILabel label;
	private int i;

	// Use this for initialization
	void Start () {
	
//		label = GameObject.Find("Label(button1)").GetComponent<UILabel>(); 

		for(i=1;i<=3;i++) {
			//		label = GameObject.Find("Label(button" + i + ")").GetComponent<UILabel>();

		}
	}
	
	// Update is called once per frame
	void Update () {
	
		//		label.text = "Count:" + i.ToString (); 

	}
}
