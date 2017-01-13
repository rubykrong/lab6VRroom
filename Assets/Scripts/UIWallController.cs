using UnityEngine;
using System.Collections;

public class UIWallController : MonoBehaviour {

	public RectTransform button0, button1, button2, button3, button4;
	public Material mat1, mat2, mat3, mat4;
	public GameObject wall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}


	public void ButtonMainEvent()
	{
		button0.gameObject.SetActive (false);
		button1.gameObject.SetActive (true);
		button2.gameObject.SetActive (true);
		button3.gameObject.SetActive (true);
		button4.gameObject.SetActive (true);
	}

	public void ButtonPick1Event()
	{
		wall.GetComponent<Renderer> ().material = mat1;
		button0.gameObject.SetActive (true);
		button1.gameObject.SetActive (false);
		button2.gameObject.SetActive (false);
		button3.gameObject.SetActive (false);
		button4.gameObject.SetActive (false);
	}

	public void ButtonPick2Event()
	{
		wall.GetComponent<Renderer> ().material = mat2;
		button0.gameObject.SetActive (true);
		button1.gameObject.SetActive (false);
		button2.gameObject.SetActive (false);
		button3.gameObject.SetActive (false);
		button4.gameObject.SetActive (false);
	}

	public void ButtonPick3Event()
	{
		wall.GetComponent<Renderer> ().material = mat3;
		button0.gameObject.SetActive (true);
		button1.gameObject.SetActive (false);
		button2.gameObject.SetActive (false);
		button3.gameObject.SetActive (false);
		button4.gameObject.SetActive (false);
	}

	public void ButtonPick4Event()
	{
		wall.GetComponent<Renderer> ().material = mat4;
		button0.gameObject.SetActive (true);
		button1.gameObject.SetActive (false);
		button2.gameObject.SetActive (false);
		button3.gameObject.SetActive (false);
		button4.gameObject.SetActive (false);
	}
}
