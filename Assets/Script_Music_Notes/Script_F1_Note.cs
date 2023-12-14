using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_F1_Note : MonoBehaviour
{
    public AudioSource F1_Note;

    void OnMouseDown()
    {

        {
            F1_Note.Play();
        }
    }
}
