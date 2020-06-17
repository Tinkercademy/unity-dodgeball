using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
	public int hp;
	private bool gameEnd = false;
	private GameObject canvas;
	
    void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("GameLossCanvas");
		canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void AdjustHp(int adjustment) {
		if (gameEnd) {
			return;
		}
		hp += adjustment;
		
		if (hp<=0) {
			gameEnd = true;
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			gameObject.GetComponent<PlayerControllerScript>().EndGame();
			canvas.SetActive(true);
		}
	}
}
