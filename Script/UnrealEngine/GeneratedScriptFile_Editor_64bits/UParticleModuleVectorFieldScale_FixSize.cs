#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldScale
	{
		static readonly int VectorFieldScale__Offset;
		/// <summary>Per-particle vector field scale. Evaluated using emitter time.</summary>
		public UDistributionFloat VectorFieldScale
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorFieldScale__Offset); if (v == IntPtr.Zero)return null; UDistributionFloat retValue = new UDistributionFloat(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VectorFieldScaleRaw__Offset;
		/// <summary>Per-particle vector field scale. Evaluated using emitter time.</summary>
		public FRawDistributionFloat VectorFieldScaleRaw
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+VectorFieldScaleRaw__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VectorFieldScaleRaw__Offset, false);}
			
		}
		
		static UParticleModuleVectorFieldScale()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVectorFieldScale");
			VectorFieldScale__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScale");
			VectorFieldScaleRaw__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScaleRaw");
			
		}
		
	}
	
}
#endif
#endif
