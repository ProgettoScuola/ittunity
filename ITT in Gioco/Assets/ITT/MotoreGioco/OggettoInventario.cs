using System;


namespace ITT.MotoreGioco
{
    [Serializable]
    public class OggettoInventario
    {

        public int id { get; set; }
        public string nome { get; set; }
        public float peso { get; set; }
        public string descrizione { get; set; }
        public int numUtilizzi { get; set; }
        public int quantita { get; set; }
        public int carica { get; set; }

        public enum TipologiaOggettoInventario {MONETE,CIBO,CHIAVE,POSTIT,BATTERIE,TRONCHESE,DETERSIVO,FIALETTE,TORCIA };

        public TipologiaOggettoInventario Tipologia { get; set; }


    }
}