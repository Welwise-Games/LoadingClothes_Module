﻿using UnityEngine;
using WelwiseClothesSharedModule.Runtime.Client.Scripts;
using WelwiseClothesSharedModule.Runtime.Client.Scripts.Example;
using WelwiseGamesSDK;
using WelwiseGamesSDK.Shared;

namespace WelwiseLoadingClothesModule.Runtime.Client.Scripts.Example
{
    public class ClothesLoader : MonoBehaviour
    {
        [SerializeField] private PlayerColorableClothesViewSerializableComponents _playerColorableClothesViewSerializableComponents;

        public async void Start()
        {
            Debug.Log(0);
            
            var sdk = WelwiseSDK.Construct().AsTransient();
            await sdk.InitializeAsync();
            
            Debug.Log(1);

            new ClothesEntryPoint().OnCreatePlayerAsync(_playerColorableClothesViewSerializableComponents,
                sdk.PlayerData.GetEquippedItemsDataFromMetaverse());
            
            Debug.Log("Clothes loaded");
        }
    }
}