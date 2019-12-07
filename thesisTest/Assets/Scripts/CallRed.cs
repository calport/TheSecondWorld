using UnityEngine;
using System.Collections;

public class CallRed : MonoBehaviour
{

	private MoveBlueMan _moveBlueMan;

	// Use this for initialization
	void Start ()
	{
		_moveBlueMan = GameObject.FindGameObjectWithTag("blue").GetComponent<MoveBlueMan>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
	 	print("Clicked");
	 	Sending.sendRed();
		StartCoroutine(_moveBlueMan.MoveMan());
	 }
}
