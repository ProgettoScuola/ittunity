using System.Collections.Generic;

namespace ITT.MotoreGioco
{

    public class Inventario
    {


        public float maxPeso = 50f;
        public List<OggettoInventario> listaOggettiInventario;


        public Inventario()
        {
            listaOggettiInventario = new List<OggettoInventario>();
        }




        public OggettoInventario aggiungiOggetto(OggettoInventario o)
        {
            if(getSommmaPesiOggettiInventario() + o.peso  < maxPeso) {
                listaOggettiInventario.Add(o);
                return o;
            }
            else
            {
                return null;//torna valore null perche ha raggiunto il peso massimo.
            }
            
        }


        public float getSommmaPesiOggettiInventario()
        {
            float somma = 0f;
            foreach(OggettoInventario o in listaOggettiInventario)
            {
                somma = somma + o.peso;
            }
            return somma;
        }
    }
}