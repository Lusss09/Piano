using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DS_Note : MonoBehaviour
{
    public AudioSource DS_Note;

    void OnMouseDown()
    {

        {
            DS_Note.Play();
        }
    }
}
