using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VAsGenerator : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        TipoArmadilha();
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
	
	public void TipoArmadilha()
	{
		int min = 0;
		int max = 4;
		
		int va = Random.Range(min, max);
		Debug.Log(va);
		//return va;
	}
}
