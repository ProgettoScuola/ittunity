using UnityEngine;
using UnityEditor;

namespace ITT.Salvataggio.Statistiche
{
    public class PlayerInfo
    {
        public Vector3 position;
        public Quaternion rotation;
        public int salute;
        public int fame;

        public PlayerInfo()
        {

        }

        public PlayerInfo(Vector3 a, Quaternion b)
        {
            position = a;
            rotation = b;
        }
    }
}