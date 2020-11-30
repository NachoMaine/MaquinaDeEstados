using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstadoEnojado : MonoBehaviour {
    public Color ColorEstado = Color.red;
    public float duracionEnojo = 4f;
    private ControladorNavMesh controladorNavMesh;


    private MaquinaDeEstados maquinaDeEstados;
    private float tiempoEnojado;

    // Use this for initialization
    void Awake () {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();




    }

    void OnEnable()
    {
        maquinaDeEstados.MeshRendererIndicador.material.color = ColorEstado;
        tiempoEnojado = 0f;
    }

    // Update is called once per frame
    void Update () {

        controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent(controladorNavMesh.perseguirObjetivo.position);
        tiempoEnojado += Time.deltaTime;
        if (tiempoEnojado >= duracionEnojo)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
            return;
        }
    }
}
