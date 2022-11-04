﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToStateIDMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] stateIDs;
        [JsonProperty] public readonly string modifierName;
    }
}