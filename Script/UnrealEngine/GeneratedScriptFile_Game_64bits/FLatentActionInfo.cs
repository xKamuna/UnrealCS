#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FLatentActionInfo
	{
		[FieldOffset(0)]
		public int Linkage;
		[FieldOffset(4)]
		public int UUID;
		[FieldOffset(8)]
		public FName ExecutionFunction;
		
	}
	
}
#endif
#endif
