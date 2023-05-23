﻿using IngredientLib.Util;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.VFX;

namespace PhoMod.Utils
{
    public static class MaterialHelper
    {
        //public static void ApplyMaterial<T>(this GameObject gameObject, Material[] materials) where T : Renderer
        //{
        //    var comp = gameObject.GetComponent<T>();
        //    if (comp == null)
        //        return;

        //    comp.materials = materials;
        //}

        //public static void ApplyMaterial(this GameObject gameObject, Material[] materials)
        //{
        //    ApplyMaterial<MeshRenderer>(gameObject, materials);
        //}

        //public static void ApplyMaterial(this GameObject gameObject, params string[] materials)
        //{
        //    ApplyMaterial<MeshRenderer>(gameObject, GetMaterialArray(materials));
        //}

        //public static void ApplyMaterialToChildren<T>(this GameObject gameObject, string nameMatch, Material[] materials) where T : Renderer
        //{
        //    for (int i = 0; i < GameObjectUtils.GetChildCount(gameObject); i++)
        //    {
        //        GameObject child = GameObjectUtils.GetChild(gameObject, i);
        //        if (!child.name.ToLower().Contains(nameMatch.ToLower()))
        //            continue;
        //        child.ApplyMaterial<T>(materials);
        //    }
        //}
        //public static void ApplyMaterialToChildren(this GameObject gameObject, string nameMatch, Material[] materials)
        //{
        //    ApplyMaterialToChildren<MeshRenderer>(gameObject, nameMatch, materials);
        //}
        //public static void ApplyMaterialToChildren(this GameObject gameObject, string nameMatch, params string[] materials)
        //{
        //    ApplyMaterialToChildren<MeshRenderer>(gameObject, nameMatch, GetMaterialArray(materials));
        //}

        //public static void ApplyMaterialToChild<T>(this GameObject gameObject, string childName, Material[] materials) where T : Renderer
        //{
        //    GameObjectUtils.GetChild(gameObject, childName).ApplyMaterial<T>(materials);
        //}

        //public static void ApplyMaterialToChild(this GameObject gameObject, string childName, Material[] materials)
        //{
        //    GameObjectUtils.GetChild(gameObject, childName).ApplyMaterial(materials);
        //}

        //public static void ApplyMaterialToChild(this GameObject gameObject, string childName, params string[] materials)
        //{
        //    GameObjectUtils.GetChild(gameObject, childName).ApplyMaterial(GetMaterialArray(materials));
        //}

        //public static Material[] GetMaterialArray(params string[] materials)
        //{
        //    List<Material> materialList = new List<Material>();
        //    foreach (string matName in materials)
        //    {
        //        string formatted = $"IngredientLib - \"{matName}\"";
        //        bool flag = CustomMaterials.CustomMaterialsIndex.ContainsKey(formatted);
        //        if (flag)
        //        {
        //            materialList.Add(CustomMaterials.CustomMaterialsIndex[formatted]);
        //        }
        //        else
        //        {
        //            materialList.Add(MaterialUtils.GetExistingMaterial(matName));
        //        }
        //    }
        //    return materialList.ToArray();
        //}

        internal static void SetupGenericCrates(GameObject prefab)
        {
            GameObjectUtils.GetChild(prefab, "GenericStorage").ApplyMaterialToChildren("Cube", "Wood - Default");
        }

        //internal static void SetupGenericFlourSack(GameObject prefab, string material)
        //{
        //    prefab.ApplyMaterialToChild("FlourSack", "Sack", material);
        //}
    }
}
