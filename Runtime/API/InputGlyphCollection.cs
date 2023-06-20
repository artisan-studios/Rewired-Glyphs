using System;
using UnityEngine;

/// <summary>
/// A <see cref="ScriptableObject"/> asset that references each <see cref="InputGlyphMap"/> that should be utilized at runtime.
/// </summary>
public class InputGlyphCollection : ScriptableObject
{
	[Tooltip("Maps to be used on specific user hardware.")]
	[SerializeField]
	private Entry[] maps = new Entry[0];
	[Space, Tooltip("Generic maps to be used when unable to find hardware specific glyphs.")]
	[SerializeField]
	private GenericEntry[] genericMaps = new GenericEntry[0];
	[Space, Tooltip("The glyph to be shown if the action exists but there is not input mapping to it.")] // TODO: DisableDropdown
	[SerializeField]
	private InputGlyph unboundGlyph;
	[Space, Tooltip("The glyph to be shown if the action does not exist, usually as a result of an action name mismatch.")] // TODO: DisableDropdown
	[SerializeField]
	private InputGlyph nullGlyph;

	public Entry[] Maps => maps;
	public GenericEntry[] GenericMaps => genericMaps;
	public InputGlyph UnboundGlyph => unboundGlyph;
	public InputGlyph NullGlyph => nullGlyph;

	[Serializable]
	public class GenericEntry
	{
		public InputGlyphs.SymbolPreference controllerType;
		public InputGlyphMap glyphMap;
	}

	[Serializable]
	public class Entry
	{
		public InputGlyphs.HardwareSymbols controllerType;
		public InputGlyphMap glyphMap;
	}
}