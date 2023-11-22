using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{	
	public GameObject[] section;
   //possition for new section
	public int posZ = 50;
	public bool creatingSection = false;
	public int sectionNum;


    void Update()
    {
     if (creatingSection == false)
     {
     	creatingSection = true;
     	StartCoroutine(GenerateSection());
     	
     }   
    }
    
    IEnumerator GenerateSection()
    {
    //Generating a random number 
    	sectionNum = Random.Range(0, 3);
    	
    // Instantiate the selected section at the specified position and with no rotation
    	Instantiate(section[sectionNum], new Vector3(0,0,posZ), Quaternion.identity);
    	
    //Moves the possition by 40 units on Z-axis
    	posZ += 40;
    	yield return new WaitForSeconds(5);
    //restarts process
    	creatingSection = false;
    }
}
