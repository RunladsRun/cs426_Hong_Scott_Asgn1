//lets add some target
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Target : MonoBehaviour
{
    public Score scoreManager;
    public int max = 0;
 
    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision) {
        //on collision adding point to the score
        max++;
        if (max <= 60) {
            scoreManager.AddPoint();
        } else {
            gameObject.tag = "Untagged";
        }
 
        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
    }
}