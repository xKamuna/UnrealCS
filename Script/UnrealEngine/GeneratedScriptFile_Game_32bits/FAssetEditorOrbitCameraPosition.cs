#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FAssetEditorOrbitCameraPosition
	{
		public bool bIsSet
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public FVector CamOrbitPoint;
		[FieldOffset(16)]
		public FVector CamOrbitZoom;
		[FieldOffset(28)]
		public FRotator CamOrbitRotation;
		
	}
	
}
#endif
#endif
