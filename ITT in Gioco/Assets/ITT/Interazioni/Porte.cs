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


        /**
         * Metodo che controlla se posso aprire o meno la porta
         * Prende la porta con cui si interagisce e controlla nel inventario se si possiede la chiave ee se necessaria
         * 
         * Return true se si puo aprire, false se non si puo aprire
         * */
        public Boolean ControllaPorta(Porta p)
        {

            if (!p.chiusa)
            {
                return true;
            }
            if (!p.serveChiave)
            {
                return true;
            }
            else
            {
                //controllo nell'inventario se ho la chiave

            }
            return false;
        }
    }
}