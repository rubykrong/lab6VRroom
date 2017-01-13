using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public GameObject player;
	public Vector3[] targets;
	public float speedWalk;
	Vector3 point;
	bool isWalk;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (isWalk) {
			Vector3 target = Vector3.MoveTowards (player.transform.position, point, speedWalk);

			player.GetComponent<Transform> ().position = new Vector3 (target.x, player.transform.position.y, target.z);
			Vector3 v = player.transform.position - point;
			if(Mathf.Abs(v.x)<=speedWalk && Mathf.Abs(v.z) <= speedWalk)
				isWalk = false;

		}

	}

	public  void GoToPoint(int i)
	{

		point = targets [i];
		isWalk = true;
	}
}
