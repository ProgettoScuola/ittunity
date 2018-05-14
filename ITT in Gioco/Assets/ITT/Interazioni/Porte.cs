using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections;


/**
 classe per le interazioni con le porte
 * */
namespace ITT.Interazione
{
    public class Porte
    {

        string stringToEdit = "Premi il bottone per aprire la porta";
        void OnGUI()
        {
            // Make a multiline text area that modifies stringToEdit.
            stringToEdit = GUI.TextArea(new Rect(10, 10, 200, 100), stringToEdit, 200);

        }

        void OnTriggerStay(Collision collision)
        {
            if (collision.collider.name == "Porta")
            {
                OnGUI();

            }

        }
    }
}