#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAudioSettings
	{
		static readonly int DefaultSoundClassName__Offset;
		public FStringAssetReference DefaultSoundClassName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultSoundClassName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultSoundClassName__Offset, false);}
			
		}
		
		static readonly int DefaultSoundConcurrencyName__Offset;
		public FStringAssetReference DefaultSoundConcurrencyName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultSoundConcurrencyName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultSoundConcurrencyName__Offset, false);}
			
		}
		
		static readonly int DefaultSoundSubmixName__Offset;
		public FStringAssetReference DefaultSoundSubmixName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultSoundSubmixName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultSoundSubmixName__Offset, false);}
			
		}
		
		static readonly int DefaultBaseSoundMix__Offset;
		public FStringAssetReference DefaultBaseSoundMix
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBaseSoundMix__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultBaseSoundMix__Offset, false);}
			
		}
		
		static readonly int VoiPSoundClass__Offset;
		public FStringAssetReference VoiPSoundClass
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+VoiPSoundClass__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VoiPSoundClass__Offset, false);}
			
		}
		
		static readonly int LowPassFilterResonance__Offset;
		public float LowPassFilterResonance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LowPassFilterResonance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowPassFilterResonance__Offset, false);}
			
		}
		
		static readonly int MaximumConcurrentStreams__Offset;
		public int MaximumConcurrentStreams
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaximumConcurrentStreams__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaximumConcurrentStreams__Offset, false);}
			
		}
		
		static readonly int QualityLevels__Offset;
		public TStructArray<FAudioQualitySettings> QualityLevels
		{
			get{ CheckIsValid();return new TStructArray<FAudioQualitySettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+QualityLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+QualityLevels__Offset, false);}
			
		}
		
		static readonly int bAllowVirtualizedSounds__Offset;
		public bool bAllowVirtualizedSounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowVirtualizedSounds__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowVirtualizedSounds__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DialogueFilenameFormat__Offset;
		public FString DialogueFilenameFormat
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DialogueFilenameFormat__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DialogueFilenameFormat__Offset, false);}
			
		}
		
		static UAudioSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AudioSettings");
			DefaultSoundClassName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSoundClassName");
			DefaultSoundConcurrencyName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSoundConcurrencyName");
			DefaultSoundSubmixName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSoundSubmixName");
			DefaultBaseSoundMix__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBaseSoundMix");
			VoiPSoundClass__Offset=GetPropertyOffset(NativeClassPtr,"VoiPSoundClass");
			LowPassFilterResonance__Offset=GetPropertyOffset(NativeClassPtr,"LowPassFilterResonance");
			MaximumConcurrentStreams__Offset=GetPropertyOffset(NativeClassPtr,"MaximumConcurrentStreams");
			QualityLevels__Offset=GetPropertyOffset(NativeClassPtr,"QualityLevels");
			bAllowVirtualizedSounds__Offset=GetPropertyOffset(NativeClassPtr,"bAllowVirtualizedSounds");
			DialogueFilenameFormat__Offset=GetPropertyOffset(NativeClassPtr,"DialogueFilenameFormat");
			
		}
		
	}
	
}
#endif
#endif
