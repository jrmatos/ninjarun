using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCrontroller : MonoBehaviour {

	private Vector3 position;
	public Animator anim;

	[Header("Animation")]
	public static bool isDead = false;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) && !isDead)
		{
			Vector3 position = this.transform.position;
			position.y++;

			if(position.y < -2.26f) {
				this.transform.position = position;				
			}

		}
		if (Input.GetKeyDown(KeyCode.DownArrow) && !isDead)
		{
			Vector3 position = this.transform.position;
			position.y--;

			if(position.y > -4.28f) {
				this.transform.position = position;				
			}
		}

		UpdateAnimatorParameters ();
	}

	void UpdateAnimatorParameters() {
		anim.SetBool("isDead", isDead);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Shuriken") {
			isDead = true;
		}
	}

}