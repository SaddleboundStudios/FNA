#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2018 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

namespace Microsoft.Xna.Framework.Input.Touch
{
	// https://msdn.microsoft.com/en-us/library/microsoft.xna.framework.input.touch.touchlocationstate.aspx
	public enum TouchLocationState
	{
		// FIXME: Check the real XNA enum values!
		Invalid,
		Moved,
		Pressed,
		Released
	}
}
