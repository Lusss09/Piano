using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_A_Note : MonoBehaviour
{
    public AudioSource A_Note;

    void OnMouseDown()
    {

        {
            A_Note.Play();
        }
    }
}
