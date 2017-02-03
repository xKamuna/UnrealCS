#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A linear color.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Color.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FLinearColor
	{
		[FieldOffset(0)]
		public float R;
		[FieldOffset(4)]
		public float G;
		[FieldOffset(8)]
		public float B;
		[FieldOffset(12)]
		public float A;
		
	}
	
}
#endif
#endif
