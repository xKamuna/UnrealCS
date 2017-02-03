#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieScene3DTransformSection
	{
		static readonly int Translation__Offset;
		public FRichCurve Translation
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Translation__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Rotation__Offset;
		public FRichCurve Rotation
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Rotation__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Scale__Offset;
		public FRichCurve Scale
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(FRichCurve));}
			
		}
		
		static UMovieScene3DTransformSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DTransformSection");
			Translation__Offset=GetPropertyOffset(NativeClassPtr,"Translation");
			Rotation__Offset=GetPropertyOffset(NativeClassPtr,"Rotation");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			
		}
		
	}
	
}
#endif
#endif
