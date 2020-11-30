using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour {
    public MonoBehaviour EstadoPatrulla;
    public MonoBehaviour EstadoAlerta;
    public MonoBehaviour EstadoPersecucion;
    public MonoBehaviour EstadoEnojado;
    public MonoBehaviour EstadoInicial;
    

    public MeshRenderer MeshRendererIndicador;
     
    private MonoBehaviour estadoActual;
	// Use this for initialization
	void Start () {
        ActivarEstado(EstadoInicial);
	}
	
	public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual!=null)estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }
}
