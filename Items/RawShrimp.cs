using IngredientLib.Util;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenPhoMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PhoMod.Items
{
    public class RawShrimp : CustomItem
    {
        public override string UniqueNameID => "RawShrimp";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Shrimp");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;

        public override void OnRegister(Item gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Shrimp", "Plastic - Grey");
        }
    }
}
