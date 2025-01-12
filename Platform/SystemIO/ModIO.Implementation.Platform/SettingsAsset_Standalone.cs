﻿#if UNITY_2019_4_OR_NEWER
using UnityEngine;

namespace ModIO.Implementation
{
    /// <summary>standalone extension to the SettingsAsset.</summary>
    internal partial class SettingsAsset : ScriptableObject
    {
        /// <summary>Configuration for Windows.</summary>
        public BuildSettings standaloneConfiguration;

#if (UNITY_STANDALONE || UNITY_WSA || UNITY_WEBGL) && !UNITY_EDITOR

        /// <summary>Gets the configuration for standalone.</summary>
        public BuildSettings GetBuildSettings()
        {
            return this.standaloneConfiguration;
        }

#endif // UNITY_STANDALONE && !UNITY_EDITOR
    }
}
#endif
