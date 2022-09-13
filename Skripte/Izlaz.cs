using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Izlaz : MonoBehaviour
{
    public void IzlazNapolje()
    {
        SceneManager.LoadScene(3);
    }
}
