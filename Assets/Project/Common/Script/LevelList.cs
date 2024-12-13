using System.Collections.Generic;
using UnityEngine;

namespace Connect.Comman
{
    [CreateAssetMenu(fileName = "Level", menuName = "SO/All Levels")]
    public class LevelList : ScriptableObject
    {
        public List<LevelData> Levels;

    }
}