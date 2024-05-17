using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Corredor", menuName = "Data/Corredores")]

public class BaseCorredores : ScriptableObject
{
    public string Nombre;
    public int Resistencia;
    public int Velocidad;
    public float Salto;
}
