using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_GS_Note : MonoBehaviour
{
    public AudioSource GS_Note;

    void OnMouseDown()
    {

        {
            GS_Note.Play();
        }
    }
}
