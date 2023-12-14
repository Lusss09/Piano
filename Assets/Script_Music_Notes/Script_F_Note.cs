using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_F_Note : MonoBehaviour
{
    public AudioSource F_Note;

    void OnMouseDown()
    {

        {
            F_Note.Play();
        }
    }
}
