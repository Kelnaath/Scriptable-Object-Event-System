using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeKittenMeowLogic : MonoBehaviour
{
    [SerializeField]
    private AudioClip kittenMeow;
    [SerializeField]
    private AudioSource aS;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExposeMeowedKitten(Kitten k)
    {
        aS.PlayOneShot(kittenMeow);
        Debug.Log(k.name + " meowed, her fluffines level is: " + k.fluffinessLevel + ". So cuuuuuuute :D");
    }
}
