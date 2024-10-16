using BepInEx;
using HarmonyLib;
using JetBrains.Annotations;
using System.Reflection;
using UnityEngine;

namespace MuteOnMinimize
{
	/// <summary>
	/// Audio manager for muting game on minimize.
	/// </summary>
	[BepInPlugin(PluginId, "Mute On Minimize", "1.0.0")]
	public class MuteAudioManager : BaseUnityPlugin
	{
		/// <summary>
		/// Plugin identifier.
		/// </summary>
		private const string PluginId = "Mugnum.MuteOnMinimize";

		/// <summary>
		/// Harmony.
		/// </summary>
		private Harmony _harmony;

		/// <summary>
		/// Process intialization of the mod.
		/// </summary>
		[UsedImplicitly]
		protected void Awake()
		{
			_harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginId);
			Application.focusChanged -= OnFocusChanged;
			Application.focusChanged += OnFocusChanged;
		}

		/// <summary>
		/// Process unloading of the mod.
		/// </summary>
		[UsedImplicitly]
		protected void OnDestroy()
		{
			Application.focusChanged -= OnFocusChanged;
			_harmony?.UnpatchSelf();
		}

		/// <summary>
		/// Handle focus change.
		/// </summary>
		/// <param name="isFocused"> Is game in focus (not minimized). </param>
		private static void OnFocusChanged(bool isFocused)
		{
			AudioListener.pause = !isFocused;
		}
	}
}
