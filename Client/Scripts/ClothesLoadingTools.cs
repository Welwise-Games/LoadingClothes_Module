using System.Collections.Generic;
using System.Linq;
using WelwiseClothesSharedModule.Runtime.Client.Scripts;
using WelwiseClothesSharedModule.Runtime.Shared.Scripts;
using WelwiseGamesSDK.Shared;
using WelwiseSharedModule.Runtime.Shared.Scripts;
using WelwiseSharedModule.Runtime.Shared.Scripts.Tools;

namespace WelwiseLoadingClothesModule.Runtime.Scripts.Client.Scripts
{
    public static class ClothesLoadingTools
    {
        public static void GetNicknameFromMetaverse(this IPlayerData playerData) =>
            playerData.MetaverseData.GetString(
                ClothesSharedTools
                    .EquippedItemsDataFieldNameForMetaverseSavings, new ClientEquippedItemsData(
                    CollectionTools.ToList<ItemCategory>()
                        .Where(category => category is not ItemCategory.All and not ItemCategory.Color)
                        .Select(category => new EquippedItemData(null, new Dictionary<int, float>(), category))
                        .ToList()).GetJsonSerializedObjectWithoutNulls());
    }
}