using WelwiseClothesSharedModule.Runtime.Client.Scripts;
using WelwiseClothesSharedModule.Runtime.Shared.Scripts;
using WelwiseGamesSDK.Shared;
using WelwiseSharedModule.Runtime.Shared.Scripts;

namespace WelwiseLoadingClothesModule.Runtime.Client.Scripts
{
    public static class ClothesLoadingTools
    {
        public static EquippedItemsData GetEquippedItemsDataFromMetaverse(this IPlayerData playerData) =>
            playerData.MetaverseData.GetString(
                    ClothesSharedTools
                        .EquippedItemsDataFieldNameForMetaverseSavings,
                    Shared.Scripts.ClothesLoadingTools.GetDefaultEquippedItemsData().GetJsonSerializedObjectWithoutNulls())
                .GetDeserializedWithoutNulls<EquippedItemsData>();
    }
}