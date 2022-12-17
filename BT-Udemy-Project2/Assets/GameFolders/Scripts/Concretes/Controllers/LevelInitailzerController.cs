using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject2.ScriptableObjects;
using UdemyProject2.Managers;

namespace UdemyProject2.Controllers
{
    public class LevelInitailzerController : MonoBehaviour
    {
        LevelDifficultyData _levelDifficultyData;

        void Awake()
        {
            _levelDifficultyData = GameManager.Instance.LevelDifficultyData;
        }
        void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.SkyboxMaterial;
            Instantiate(_levelDifficultyData.FloorPrefab);
            Instantiate(_levelDifficultyData.SpawnerPrefab);
            EnemyManager.Instance.SetMoveSpeed(_levelDifficultyData.MoveSpeed);
            EnemyManager.Instance.SetAddDelayTime(_levelDifficultyData.AddDelayTime);
        }
    }
}