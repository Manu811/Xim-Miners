﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComoJugar : MonoBehaviour
{
    public void Regresar()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("¿Regresar?");
    }
}
