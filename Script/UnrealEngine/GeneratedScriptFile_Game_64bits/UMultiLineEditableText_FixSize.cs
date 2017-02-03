#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMultiLineEditableText
	{
		static readonly int Text__Offset;
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int HintText__Offset;
		public string HintText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+HintText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+HintText__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		public FTextBlockStyle WidgetStyle
		{
			get{ CheckIsValid();return (FTextBlockStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FTextBlockStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			
		}
		
		static readonly int AllowContextMenu__Offset;
		public bool AllowContextMenu
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowContextMenu__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowContextMenu__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnTextChanged__Offset;
		public FMulticastScriptDelegate OnTextChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextChanged__Offset, false);}
			
		}
		
		static readonly int OnTextCommitted__Offset;
		public FMulticastScriptDelegate OnTextCommitted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextCommitted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextCommitted__Offset, false);}
			
		}
		
		static UMultiLineEditableText()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MultiLineEditableText");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			HintText__Offset=GetPropertyOffset(NativeClassPtr,"HintText");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			AllowContextMenu__Offset=GetPropertyOffset(NativeClassPtr,"AllowContextMenu");
			OnTextChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnTextChanged");
			OnTextCommitted__Offset=GetPropertyOffset(NativeClassPtr,"OnTextCommitted");
			
		}
		
	}
	
}
#endif
#endif
