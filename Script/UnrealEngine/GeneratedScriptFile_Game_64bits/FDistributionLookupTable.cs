#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FDistributionLookupTable
	{
		[FieldOffset(0)]
		public byte Op;
		[FieldOffset(1)]
		public byte EntryCount;
		[FieldOffset(2)]
		public byte EntryStride;
		[FieldOffset(3)]
		public byte SubEntryStride;
		[FieldOffset(4)]
		public float TimeScale;
		[FieldOffset(8)]
		public float TimeBias;
		public TStructArray<float> Values
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(32)]
		public byte LockFlag;
		
	}
	
}
#endif
#endif
