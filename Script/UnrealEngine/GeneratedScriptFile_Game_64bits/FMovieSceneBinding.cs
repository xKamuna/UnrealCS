#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMovieSceneBinding
	{
		[FieldOffset(0)]
		public FGuid ObjectGuid;
		[FieldOffset(16)]
		public FString BindingName;
		public TObjectArray<UMovieSceneTrack> Tracks
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
