using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittenManager : MonoBehaviour
{
    Kitten ranja = new Kitten("ranja", 9001);

    public KittenEvent OnKittenMeow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Meow()
    {
        OnKittenMeow.Invoke(ranja);
    }
}
