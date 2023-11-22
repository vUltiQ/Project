using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    public bool isJumping = false;
    public bool fallingDown = false;
    public GameObject playerObject;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundry.leftSide) {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }

        }
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundry.rightSide) {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }

        }
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
           if(isJumping == false)
           {
              isJumping = true;
              playerObject.GetComponent<Animator>().Play("Jump");
              StartCoroutine(JumpSequence());
           }
        } 
    if(isJumping == true)
    {
    	if(fallingDown == false)
    	{
    	   transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);
    	}
    	if(fallingDown == true)
    	{
    	   transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
    	}
    }
    }
    
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        fallingDown = true;
        yield return new WaitForSeconds(0.45f);
	isJumping = false;
	fallingDown = false;
	playerObject.GetComponent<Animator>().Play("Running");
    }
}
