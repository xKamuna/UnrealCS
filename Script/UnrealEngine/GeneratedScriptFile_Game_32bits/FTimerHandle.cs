#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FTimerHandle
	{
		[FieldOffset(0)]
		public ulong Handle;
		
	}
	
}
#endif
#endif
