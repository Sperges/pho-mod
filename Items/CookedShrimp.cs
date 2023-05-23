using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenPhoMod;
using UnityEngine;

namespace PhoMod.Items
{
    public class CookedShrimp : CustomItem
    {
        public override string UniqueNameID => "CookedShrimp";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Shrimp");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;

        public override void OnRegister(Item gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Shrimp", "Raw Fish Pink");
        }
    }
}
