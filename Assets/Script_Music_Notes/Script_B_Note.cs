using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_B_Note : MonoBehaviour
{
    public AudioSource B_Note;

    void OnMouseDown()
    {

        {
            B_Note.Play();
        }
    }
}
