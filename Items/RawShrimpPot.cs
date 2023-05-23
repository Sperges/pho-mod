using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using PhoMod.Utils;
using KitchenData;
using Kitchen;
using Unity.Entities;
using KitchenLib.Utils;
using KitchenLib.Customs;
using KitchenPhoMod;
using static KitchenData.ItemGroup;

namespace PhoMod.Items
{
    public class RawShrimpPot : CustomItemGroup<RawShrimpPotGroupView>
    {
        public override string UniqueNameID => "RawShrimpPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ShrimpPot");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.Small;
        public override Item DisposesTo => Refs.Pot;

        public override List<ItemSet> Sets => new()
        {
            new()
            {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new()
                {
                    Refs.Pot,
                },
            },
            new()
            {
                Max = 1,
                Min = 1,
                Items = new()
                {
                    Refs.Water,
                },
            },
            new()
            {
                Max = 1,
                Min = 1,
                Items = new()
                {
                    Refs.RawShrimp,
                },
            },
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Duration = 5f,
                Process = Refs.Cook,
                Result = Refs.CookedShrimpPot,
            },
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Pot", "Metal");
            Prefab.ApplyMaterialToChild("Shrimp", "Plastic - Grey");
            Prefab.ApplyMaterialToChild("Water", "Water");

            Prefab.GetComponent<RawShrimpPotGroupView>()?.Setup(Prefab);
        }
    }

    public class RawShrimpPotGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Pot"),
                    Item = Refs.Pot,
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Shrimp"),
                    Item = Refs.RawShrimp,
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Water"),
                    Item = Refs.Water,
                },
            };

            ComponentLabels = new()
            {
                new()
                {
                    Text = "Sh",
                    Item = Refs.RawShrimp,
                },
                new()
                {
                    Text = "W",
                    Item = Refs.Water,
                },
            };
        }
    }
}
