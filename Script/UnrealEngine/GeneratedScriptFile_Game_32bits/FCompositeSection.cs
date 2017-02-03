#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FCompositeSection
	{
		[FieldOffset(40)]
		public FName SectionName;
		[FieldOffset(48)]
		public float StartTime;
		[FieldOffset(56)]
		public FName NextSectionName;
		public TObjectArray<UAnimMetaData> MetaData
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UAnimMetaData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+64, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+64, false);}}}
			
		}
		[FieldOffset(8)]
		public int SlotIndex;
		[FieldOffset(12)]
		public int SegmentIndex;
		[FieldOffset(16)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(17)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(20)]
		public float SegmentBeginTime;
		[FieldOffset(24)]
		public float SegmentLength;
		[FieldOffset(28)]
		public float LinkValue;
		
	}
	
}
#endif
#endif