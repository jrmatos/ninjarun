using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateHUD : MonoBehaviour {

	public Text txt;
	public static int score = 0;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
		txt.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Score: " + score;
	}
}
