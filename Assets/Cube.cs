using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float SizeModifier = 2.5f;

    public string newName = "Cubey1337";

    public bool isRotated = false;

    // Used for initialization
    void Start()
    {
        transform.localScale *= SizeModifier;
        transform.name = newName;
    }

    // Called once per frame
    private void Update()
    {
        transform.localScale = Vector3.one * SizeModifier;
    }

    string ImproveName(string originaleString)
    {
        return $"-[{originaleString}]-";
    }
}
