#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FCameraPreviewInfo
	{
		[FieldOffset(16)]
		public FVector Location;
		[FieldOffset(28)]
		public FRotator Rotation;
		
	}
	
}
#endif
#endif
