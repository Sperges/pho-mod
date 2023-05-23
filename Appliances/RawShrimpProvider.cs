using IngredientLib.Util;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenPhoMod;
using PhoMod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace PhoMod.Appliances
{
    public class RawShrimpProvider : CustomAppliance
    {
        public override string UniqueNameID => "RawShrimpProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawShrimpProvider");
        public override PriceTier PriceTier => PriceTier.Medium;
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateApplianceInfo("Raw Shrimp Provider", "Provides raw shrimp", new(), new()) )
        };

        public override List<IApplianceProperty> Properties => new()
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(Refs.RawShrimp.ID)
        };
        
        public override void OnRegister(Appliance gameDataObject)
        {
            var genericStorage = GameObjectUtils.GetChild(Prefab, "GenericStorage");
            genericStorage.ApplyMaterialToChild("Cube", "Wood - Default");
            genericStorage.ApplyMaterialToChild("Cube2", "Wood - Default");
            genericStorage.ApplyMaterialToChild("Cube3", "Wood - Default");


            //GameObjectUtils.GetChild(Prefab, "GenericStorage").ApplyMaterialToChildren("Wood - Default");

            // DOES NOT WORK?
            //GameObjectUtils.GetChild(Prefab, "Shrimps").ApplyMaterialToChildren("Raw Fish Pink");

            var shrimps = GameObjectUtils.GetChild(Prefab, "Shrimps");
            shrimps.ApplyMaterialToChild("Shrimp", "Plastic - Grey");
            shrimps.ApplyMaterialToChild("Shrimp2", "Plastic - Grey");
            shrimps.ApplyMaterialToChild("Shrimp3", "Plastic - Grey");
            shrimps.ApplyMaterialToChild("Shrimp4", "Plastic - Grey");

        }
    }
}
