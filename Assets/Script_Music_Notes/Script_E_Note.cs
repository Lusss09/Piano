using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_E_Note : MonoBehaviour
{
    public AudioSource E_Note;

    void OnMouseDown()
    {

        {
            E_Note.Play();
        }
    }
}
