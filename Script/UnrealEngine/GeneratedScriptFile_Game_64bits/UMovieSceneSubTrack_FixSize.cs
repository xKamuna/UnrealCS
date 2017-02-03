#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSubTrack
	{
		static readonly int Sections__Offset;
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static UMovieSceneSubTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSubTrack");
			Sections__Offset=GetPropertyOffset(NativeClassPtr,"Sections");
			
		}
		
	}
	
}
#endif
#endif
