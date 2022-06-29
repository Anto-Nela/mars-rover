using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

   
    PlayerMovement cc;
 void Start () {
        cc = GetComponent<PlayerMovement>();
 }
 
 
 void Update () {
        if ( Input.GetButtonDown( "Horizontal" ) || Input.GetButtonDown( "Vertical" ) )
        GetComponent<AudioSource>().Play();
    else if ( !Input.GetButton( "Horizontal" ) && !Input.GetButton( "Vertical" ) && GetComponent<AudioSource>().isPlaying )
        GetComponent<AudioSource>().Stop();
 }
}