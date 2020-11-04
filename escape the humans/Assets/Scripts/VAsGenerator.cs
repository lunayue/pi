using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VAsGenerator : MonoBehaviour
{
	
	public void TipoArmadilha()
	{
		int min = 0;
		int max = 4;
		
		int va = Random.Range(min, max);
		Debug.Log(va);
		//return va;
	}
	
	public void VelocidadeArmadilha()
	{
		float min = 1;
		float max = 5;
		int deslocamento = 0;
		
		float va = Random.Range(min, max) + deslocamento;
		Debug.Log(va);
		//return va;
	}
	
	public void NArmadilha()
	{
		int y = 1;
		int deslocamento = 0;
		
		float b = 1;
		int i = 0;
		
		for(; b>= Mathf.Exp(-(y+deslocamento)); i++){
			b = b*Random.Range(0f, 1f);
		}
		
		int va = i -1;
		Debug.Log(va);
		//return va;
	}
	
	public void PontosBalasArmadilha()
	{
		int va = -1;
		int deslocamento = -1;
		float prob = Random.Range(0f, 1f);
		
		if(deslocamento == -1)
		{
			if(prob <= 0.2){
				va = 0;
			}
			else if(prob <= 0.6)
			{
				va = 1;
			}
			else
			{
				va = 2;
			}
		}
		
		else
		{
			if(prob <= 0.1)
			{
				va = 0 + deslocamento;
			}
			else if(prob <= 0.3)
			{
				va = 1 + deslocamento;
			}
			else if(prob <= 0.7)
			{
				va = 2 + deslocamento;
			}
			else if(prob <= 0.9)
			{
				va = 3 + deslocamento;
			}
			else
			{
				va = 4 + deslocamento;
			}
		}
		
		Debug.Log(va);
		//return va;
	}
	
	public void PosicaoPlataforma()
	{
		float min = -2;
		float max = 2;
		
		//Codigo gaussiana
		
		float media = 0;
		float sigma = 1;
		
		float p, p1, p2;
		
		do
		{
			p1 = Random.Range(-1f, 1f);
			p2 = Random.Range(-1f, 1f);
			p = p1*p1 + p2*p2;
		}while(p >= 1);
		
		float va = media + sigma*p1*Mathf.Sqrt(-2f*Mathf.Log(p)/p);
		
		if(va > max)
		{
			va = max;
		}
		
		if(va < -2)
		{
			va = min;
		}
		
		Debug.Log(va);
		//return va;
	}
}
