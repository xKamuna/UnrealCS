#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNetworkSettings
	{
		static readonly int bVerifyPeer__Offset;
		public bool bVerifyPeer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVerifyPeer__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVerifyPeer__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableMultiplayerWorldOriginRebasing__Offset;
		public bool bEnableMultiplayerWorldOriginRebasing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMultiplayerWorldOriginRebasing__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMultiplayerWorldOriginRebasing__Offset, 1,0,2,2);}
			
		}
		
		static UNetworkSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetworkSettings");
			bVerifyPeer__Offset=GetPropertyOffset(NativeClassPtr,"bVerifyPeer");
			bEnableMultiplayerWorldOriginRebasing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMultiplayerWorldOriginRebasing");
			
		}
		
	}
	
}
#endif
#endif
