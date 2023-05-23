using Kitchen;
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

namespace PhoMod.Items
{
    public class CookedShrimpPot : CustomItem
    {
        public override string UniqueNameID => "CookedShrimpPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedShrimpPot");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 1f;
        public override int SplitCount => 3;
        public override Item SplitSubItem => Refs.CookedShrimp;
        public override List<Item> SplitDepletedItems => new() { Refs.Pot };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;
        public override string ColourBlindTag => "Sh";

        public override void OnRegister(Item gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Pot", "Metal");
            Prefab.ApplyMaterialToChild("Shrimp", "Raw Fish Pink");

            if (!Prefab.HasComponent<CookedShrimpPotItemView>())
            {
                var view = Prefab.AddComponent<CookedShrimpPotItemView>();
                view.Setup(Prefab);
            }
        }
    }

    public class CookedShrimpPotItemView : PositionSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fFullPosition = ReflectionUtils.GetField<PositionSplittableView>("FullPosition");
            fFullPosition.SetValue(this, new Vector3(0, 0.273f, 0));

            var fEmptyPosition = ReflectionUtils.GetField<PositionSplittableView>("EmptyPosition");
            fEmptyPosition.SetValue(this, new Vector3(0, 0.028f, 0));

            var fObjects = ReflectionUtils.GetField<PositionSplittableView>("Objects");

            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("Shrimp")
            });
        }
    }
}
