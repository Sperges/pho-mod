using IngredientLib.Util;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenPhoMod;
using PhoMod.Appliances;
using PhoMod.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PhoMod.Utils
{
    public class Refs
    {
        // Vanilla References
        public static Process Cook => Find<Process>(ProcessReferences.Cook);
        public static Item Pot => Find<Item>(ItemReferences.Pot);
        public static Item Water => Find<Item>(ItemReferences.Water);

        // Mod References
        public static Item CookedShrimp = Find<Item, CookedShrimp>();
        public static Item CookedShrimpPot = Find<Item, CookedShrimpPot>();
        public static Item RawShrimp = Find<Item, RawShrimp>();
        public static Appliance RawShrimpProvider = Find<Appliance, RawShrimpProvider>();

        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }

        internal static T Find<T, C>() where T : GameDataObject where C : CustomGameDataObject
        {
            return GDOUtils.GetCastedGDO<T, C>();
        }

        internal static T Find<T>(string modName, string name) where T : GameDataObject
        {
            return GDOUtils.GetCastedGDO<T>(modName, name);
        }
    }
}
