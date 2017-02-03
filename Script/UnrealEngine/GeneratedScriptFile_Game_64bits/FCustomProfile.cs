#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FCustomProfile
	{
		[FieldOffset(0)]
		public FName Name;
		public TStructArray<FResponseChannel> CustomResponses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FResponseChannel>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
