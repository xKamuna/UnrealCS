#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInheritableComponentHandler
	{
		static readonly int Records__Offset;
		public TStructArray<FComponentOverrideRecord> Records
		{
			get{ CheckIsValid();return new TStructArray<FComponentOverrideRecord>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Records__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Records__Offset, false);}
			
		}
		
		static UInheritableComponentHandler()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InheritableComponentHandler");
			Records__Offset=GetPropertyOffset(NativeClassPtr,"Records");
			
		}
		
	}
	
}
#endif
#endif
