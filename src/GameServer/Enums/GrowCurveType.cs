﻿using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GrowCurveType
    {
        GROW_CURVE_HP_S4,
        GROW_CURVE_HP_S5,
        GROW_CURVE_ATTACK_S4,
        GROW_CURVE_ATTACK_S5,
        GROW_CURVE_ATTACK_101,
        GROW_CURVE_ATTACK_102,
        GROW_CURVE_ATTACK_104,
        GROW_CURVE_CRITICAL_101,
        GROW_CURVE_ATTACK_201,
        GROW_CURVE_ATTACK_202,
        GROW_CURVE_ATTACK_203,
        GROW_CURVE_ATTACK_204,
        GROW_CURVE_CRITICAL_201,
        GROW_CURVE_ATTACK_301,
        GROW_CURVE_ATTACK_302,
        GROW_CURVE_ATTACK_303,
        GROW_CURVE_ATTACK_304,
        GROW_CURVE_CRITICAL_301
    }
}