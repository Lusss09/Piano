using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_FS_Note : MonoBehaviour
{
    public AudioSource FS_Note;

    void OnMouseDown()
    {

        {
            FS_Note.Play();
        }
    }
}
