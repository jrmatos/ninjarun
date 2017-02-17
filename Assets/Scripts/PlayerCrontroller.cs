using UnityEngine;
using System.Collections;

public class PlayerCrontroller : MonoBehaviour {

	private Vector3 position;

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.y++;

			if(position.y < -2.26f) {
				this.transform.position = position;				
			}

		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Vector3 position = this.transform.position;
			position.y--;

			if(position.y > -4.28f) {
				this.transform.position = position;				
			}
		}
	}

    public void OnTriggerEnter(Collider collider) {
    	 Debug.Log("OnTriggerEnter ===>");
    }

}