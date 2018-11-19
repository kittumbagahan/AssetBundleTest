using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Download()
    {
        //WWW bundleWWW = WWW.LoadFromCacheOrDownload()
        yield return new WaitForSeconds (1);
    }
}
