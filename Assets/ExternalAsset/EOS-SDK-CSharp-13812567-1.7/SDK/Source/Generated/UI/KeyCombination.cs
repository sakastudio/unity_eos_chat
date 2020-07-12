// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Enum flags for storing a key combination. The low 16 bits are the key type, and modifiers are
	/// stored in the next significant bits
	/// </summary>
	[Flags]
	public enum KeyCombination : int
	{
		/// <summary>
		/// Number of bits to shift the modifiers into the integer.
		/// </summary>
		ModifierShift = 16,
		/// <summary>
		/// A mask to isolate the single key.
		/// </summary>
		KeyTypeMask = (1 << ModifierShift) - 1,
		/// <summary>
		/// A mask to isolate the modifier keys.
		/// </summary>
		ModifierMask = ~KeyTypeMask,
		/// <summary>
		/// The Shift key
		/// </summary>
		Shift = (1 << ModifierShift),
		/// <summary>
		/// The Control key
		/// </summary>
		Control = (2 << ModifierShift),
		/// <summary>
		/// The Alt key
		/// </summary>
		Alt = (4 << ModifierShift),
		/// <summary>
		/// The Windows key on a Windows keyboard or the Command key on a Mac keyboard
		/// </summary>
		Meta = (8 << ModifierShift),
		ValidModifierMask = (Shift | Control | Alt | Meta),
		None = 0,
		Space,
		Backspace,
		Tab,
		Escape,
		PageUp,
		PageDown,
		End,
		Home,
		Insert,
		Delete,
		Left,
		Up,
		Right,
		Down,
		Key0,
		Key1,
		Key2,
		Key3,
		Key4,
		Key5,
		Key6,
		Key7,
		Key8,
		Key9,
		KeyA,
		KeyB,
		KeyC,
		KeyD,
		KeyE,
		KeyF,
		KeyG,
		KeyH,
		KeyI,
		KeyJ,
		KeyK,
		KeyL,
		KeyM,
		KeyN,
		KeyO,
		KeyP,
		KeyQ,
		KeyR,
		KeyS,
		KeyT,
		KeyU,
		KeyV,
		KeyW,
		KeyX,
		KeyY,
		KeyZ,
		Numpad0,
		Numpad1,
		Numpad2,
		Numpad3,
		Numpad4,
		Numpad5,
		Numpad6,
		Numpad7,
		Numpad8,
		Numpad9,
		NumpadAsterisk,
		NumpadPlus,
		NumpadMinus,
		NumpadPeriod,
		NumpadDivide,
		F1,
		F2,
		F3,
		F4,
		F5,
		F6,
		F7,
		F8,
		F9,
		F10,
		F11,
		F12,
		F13,
		F14,
		F15,
		F16,
		F17,
		F18,
		F19,
		F20,
		F21,
		F22,
		F23,
		F24,
		OemPlus,
		OemComma,
		OemMinus,
		OemPeriod,
		/// <summary>
		/// ';' for US layout, others vary
		/// </summary>
		Oem1,
		/// <summary>
		/// '/' for US layout, others vary
		/// </summary>
		Oem2,
		/// <summary>
		/// '~' for US layout, others vary
		/// </summary>
		Oem3,
		/// <summary>
		/// '[' for US layout, others vary
		/// </summary>
		Oem4,
		/// <summary>
		/// '\' for US layout, others vary
		/// </summary>
		Oem5,
		/// <summary>
		/// ']' for US layout, others vary
		/// </summary>
		Oem6,
		/// <summary>
		/// '"' for US layout, others vary
		/// </summary>
		Oem7,
		/// <summary>
		/// varies on all layouts
		/// </summary>
		Oem8,
		/// <summary>
		/// Maximum key enumeration value.
		/// </summary>
		MaxKeyType
	}
}