#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHorizontalBoxSlot
	{
		static readonly int Padding__Offset;
		/// <summary>The amount of padding between the slots parent and the content.</summary>
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int Size__Offset;
		/// <summary>How much space this slot should occupy in the direction of the panel.</summary>
		public FSlateChildSize Size
		{
			get{ CheckIsValid();return (FSlateChildSize)Marshal.PtrToStructure(_this.Get()+Size__Offset, typeof(FSlateChildSize));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Size__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static UHorizontalBoxSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HorizontalBoxSlot");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			Size__Offset=GetPropertyOffset(NativeClassPtr,"Size");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			
		}
		
	}
	
}
#endif
#endif
