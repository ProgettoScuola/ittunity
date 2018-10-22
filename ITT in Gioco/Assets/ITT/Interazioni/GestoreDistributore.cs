using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections;
using ITT.MotoreGioco;

/**
 classe per le interazioni con le porte
 * */
namespace ITT.Interazione
{
    public class GestoreDistributore
    {


        /// <summary>
        /// controlla se è possibile prendere cibo dal distruibutore, verificando se si hanno monete nell'inventario.
        /// se si hanno monete verrà tolta una moneta dall'inventario e aggiunto un unità di cibo.
        /// </summary>
        /// <param name="ogg">Oggetto di interazione di tipologia distributore</param>
        /// <param name="inventario">Inventario dell'utente</param>
        /// <returns> Ritorna il valore booleano true se il controllo è andato a buon fine, altrimenti torna false</returns>     
        public Boolean ControllaDistributore(OggettoDiInterazione ogg,Inventario inventario)
        {
            if (ogg.Tipologia != OggettoDiInterazione.TipologiaOgettoDiInterazione.DISTRIBUTORE)
            {
                return false;
            }

            if (!ogg.accessibile)
            {
                return false;
            }
            else
            {
              
                OggettoInventario monete = inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.MONETE);
                if (monete.quantita > 0)
                {
                    monete.quantita -= 1;
                    OggettoInventario cibo = inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.CIBO);
                    cibo.quantita += 1;
                    return true;
                }

            }
            return false;
        }
    }
}