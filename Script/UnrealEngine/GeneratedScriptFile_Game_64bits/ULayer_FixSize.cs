#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULayer
	{
		static readonly int LayerName__Offset;
		public FName LayerName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LayerName__Offset, typeof(FName));}
			
		}
		
		static readonly int bIsVisible__Offset;
		public bool bIsVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVisible__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ActorStats__Offset;
		public TStructArray<FLayerActorStats> ActorStats
		{
			get{ CheckIsValid();return new TStructArray<FLayerActorStats>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActorStats__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActorStats__Offset, false);}
			
		}
		
		static ULayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Layer");
			LayerName__Offset=GetPropertyOffset(NativeClassPtr,"LayerName");
			bIsVisible__Offset=GetPropertyOffset(NativeClassPtr,"bIsVisible");
			ActorStats__Offset=GetPropertyOffset(NativeClassPtr,"ActorStats");
			
		}
		
	}
	
}
#endif
#endif
