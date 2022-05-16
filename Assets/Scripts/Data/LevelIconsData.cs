using System;
using System.Collections.Generic;
using Controllers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [Serializable]
    public class LevelIconModel
    {
        public AnimalType type;
        public Sprite sprite;
        public Sprite tailSprite;
    }

    [CreateAssetMenu(fileName = "LevelIconsData", menuName = "Data/LevelIconsData")]
    public class LevelIconsData : ScriptableObject
    {
        public LevelIcon levelIconPrefab;
        public TailIcon tailIconPrefab;
        public List<LevelIconModel> levelIconModels = new List<LevelIconModel>();

        public Sprite GetSpriteByType(AnimalType type) => levelIconModels.Find(x => x.type == type).sprite;
        public Sprite GetTailSpriteByType(AnimalType type) => levelIconModels.Find(x => x.type == type).tailSprite;
    }

    [Serializable]
    public enum AnimalType
    {
        Pig = 0,
        Cat,
        Dog,
        Mouse,
        Cow,
        Horse
    }
}