using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
	public int coins;
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider Col)
    {
    	if(Col.gameObject.tag == "Coin")
    	{
    	      coins = coins + 1;
    	      Col.gameObject.SetActive(false);
    	}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
