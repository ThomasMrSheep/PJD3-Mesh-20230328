using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMesh
{
    public Mesh Generate()
    {
        Mesh mesh = new Mesh();
        mesh.name = "CustomMesh";

        Vector3[] vertices = new Vector3[8]
        {
            //0 Esquerda Inf
            new Vector3(0,0,0),
            //1 Direita inf.
            new Vector3(1,0,0),
            //2 Direita sup.
            new Vector3(1,1,0),
            //3 Esquerda Sup.
            new Vector3(0,1,0),
            //4 Esqueda sup fund.
            new Vector3(0,1,1),
            //5 Esquerda inf fund.
            new Vector3(0,0,1),
            //6 Direita inf fund.
            new Vector3(1,0,1),
            //7 Direita sup fund.
            new Vector3(1,1,1)
        };
        mesh.vertices = vertices;

        int[] triangles = new int[36]
        {
            //Parede frente
            0,2,1,
            0,3,2,
            //Parede esquerda
            0,5,4,
            0,4,3,
            //Parede teto
            3,4,2,
            2,4,7,
            //Parede chao
            0,1,5,
            1,6,5,
            //Parede direita
            6,2,7,
            6,1,2,
            //Parede fundo
            6,7,4,
            6,4,5
            //PARA ADICIONAR DOS DOIS LADOS SO REPETIR TODAS AS VARIAVEIS DE CIMA E TROCAR OS DOIS ULTIMOS NUMEROS DE CADA TRIO.
        };
        mesh.triangles = triangles;


        return mesh;
    }
}
