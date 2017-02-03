#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionParameter
	{
		static readonly int ParameterName__Offset;
		public FName ParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParameterName__Offset, false);}
			
		}
		
		static readonly int ExpressionGUID__Offset;
		public FGuid ExpressionGUID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ExpressionGUID__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Group__Offset;
		public FName Group
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+Group__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Group__Offset, false);}
			
		}
		
		static UMaterialExpressionParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionParameter");
			ParameterName__Offset=GetPropertyOffset(NativeClassPtr,"ParameterName");
			ExpressionGUID__Offset=GetPropertyOffset(NativeClassPtr,"ExpressionGUID");
			Group__Offset=GetPropertyOffset(NativeClassPtr,"Group");
			
		}
		
	}
	
}
#endif
#endif
