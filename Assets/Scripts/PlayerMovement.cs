using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 6.0f;
	public float jumpSpeed = 9.0f;
	public float gravity = 15.0f;
	public bool platform = false; 
	public GameObject movingPlatform;
	public bool activePlatform = false;

	private Vector3 movement = Vector3.zero;
	private MovingPlatform movingplatform;
	
	void Update () { 

		CharacterController controller = GetComponent<CharacterController> ();

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector3 (Time.deltaTime * speed, 0, 0));
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector3 (-Time.deltaTime * speed, 0, 0));
		}
		if (controller.isGrounded) {
			if (Input.GetKey (KeyCode.Space)) {
				movement.y = jumpSpeed;
			}

		}
		movement.y -= gravity * Time.deltaTime;
		controller.Move (movement * Time.deltaTime);
		//if active platform is true then add platform speed to movement
	


	}
	void OnPlatform () {
		//set active platform to the platform character is on
		activePlatform = true;
		Debug.Log ("works");
	}

	void OffPlatform () {
		activePlatform = false;
		Debug.Log ("alsoworks");
	}

	void KillPlayer(){
		Application.LoadLevel(0);
	}
		/*
     * TO DO:
     * Movement
     *      Should use the CharacterController which is already attached to this GameObject
     *      Be able to move left and right
     *      Collide with/be stopped by walls
     *      Not move too quickly or slowly
     *          Remember that movement happens every frame
     * Jumping/Falling
     *      Fall to the ground, and not through it
     *      Able to jump
     *      Can reach platforms to the right, but not the one on the left
     *      Only able to jump while standing on the ground
     * Input
     *      Ideally, use the KeyboardInput script which is already attached to this GameObject
     *      A & D for left and right movement
     *      Space for jumping
     * Moving Platform
     *      When standing on the platform, the character should stay on it/move relative to the moving platform
     *      When not standing on the platform, revert to normal behavior
     * Enemy
     *      If the character touches the enemy, he should "die"
     *      
     * 
     * 
     * 
     * Variables you might want:
     *      References to the CharacterController and Keyboard input classes
     *      Speed values for moving, falling, and jumping
     *      A value to keep track of the player's movement speed and direction
     *      You will probably need to use the Update function as well as create functions for moving platforms and enemies
     */
	}
