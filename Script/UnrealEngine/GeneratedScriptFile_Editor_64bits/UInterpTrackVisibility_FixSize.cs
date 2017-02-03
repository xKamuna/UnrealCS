#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackVisibility
	{
		static readonly int VisibilityTrack__Offset;
		/// <summary>Array of events to fire off.</summary>
		public TStructArray<FVisibilityTrackKey> VisibilityTrack
		{
			get{ CheckIsValid();return new TStructArray<FVisibilityTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VisibilityTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VisibilityTrack__Offset, false);}
			
		}
		
		static readonly int bFireEventsWhenForwards__Offset;
		/// <summary>If events should be fired when passed playing the sequence forwards.</summary>
		public bool bFireEventsWhenForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenForwards__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenForwards__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bFireEventsWhenBackwards__Offset;
		/// <summary>If events should be fired when passed playing the sequence backwards.</summary>
		public bool bFireEventsWhenBackwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenBackwards__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenBackwards__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bFireEventsWhenJumpingForwards__Offset;
		/// <summary>If true, events on this track are fired even when jumping forwads through a sequence - for example, skipping a cinematic.</summary>
		public bool bFireEventsWhenJumpingForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1,0,4,4);}
			
		}
		
		static UInterpTrackVisibility()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackVisibility");
			VisibilityTrack__Offset=GetPropertyOffset(NativeClassPtr,"VisibilityTrack");
			bFireEventsWhenForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenForwards");
			bFireEventsWhenBackwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenBackwards");
			bFireEventsWhenJumpingForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenJumpingForwards");
			
		}
		
	}
	
}
#endif
#endif
