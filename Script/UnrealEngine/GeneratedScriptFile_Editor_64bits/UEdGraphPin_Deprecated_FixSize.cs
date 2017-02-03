#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraphPin_Deprecated
	{
		static readonly int PinName__Offset;
		/// <summary>Name of this pin</summary>
		public FString PinName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PinName__Offset, typeof(FString));}
			
		}
		
		static readonly int PinFriendlyName__Offset;
		/// <summary>Used as the display name if set</summary>
		public string PinFriendlyName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+PinFriendlyName__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int PinToolTip__Offset;
		/// <summary>The tool-tip describing this pin's purpose</summary>
		public FString PinToolTip
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PinToolTip__Offset, typeof(FString));}
			
		}
		
		static readonly int Direction__Offset;
		/// <summary>Direction of flow of this pin (input or output)</summary>
		public EEdGraphPinDirection Direction
		{
			get{ CheckIsValid();return (EEdGraphPinDirection)Marshal.PtrToStructure(_this.Get()+Direction__Offset, typeof(EEdGraphPinDirection));}
			
		}
		
		static readonly int PinType__Offset;
		/// <summary>The type of information carried on this pin</summary>
		public FEdGraphPinType PinType
		{
			get{ CheckIsValid();return (FEdGraphPinType)Marshal.PtrToStructure(_this.Get()+PinType__Offset, typeof(FEdGraphPinType));}
			
		}
		
		static readonly int DefaultValue__Offset;
		/// <summary>Default value for this pin (used if the pin has no connections), stored as a string</summary>
		public FString DefaultValue
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DefaultValue__Offset, typeof(FString));}
			
		}
		
		static readonly int AutogeneratedDefaultValue__Offset;
		/// <summary>Initial default value (the autogenerated value, to identify if the user has modified the value), stored as a string</summary>
		public FString AutogeneratedDefaultValue
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+AutogeneratedDefaultValue__Offset, typeof(FString));}
			
		}
		
		static readonly int DefaultObject__Offset;
		/// <summary>If the default value for this pin should be an object, we store a pointer to it</summary>
		public UObject DefaultObject
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultObject__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultTextValue__Offset;
		/// <summary>If the default value for this pin should be an FText, it is stored here.</summary>
		public string DefaultTextValue
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DefaultTextValue__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int LinkedTo__Offset;
		/// <summary>Set of pins that we are linked to</summary>
		public TObjectArray<UEdGraphPin_Deprecated>  LinkedTo
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphPin_Deprecated>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinkedTo__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinkedTo__Offset, false);}
			
		}
		
		static readonly int SubPins__Offset;
		/// <summary>The pins created when a pin is split and hidden</summary>
		public TObjectArray<UEdGraphPin_Deprecated>  SubPins
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphPin_Deprecated>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubPins__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubPins__Offset, false);}
			
		}
		
		static readonly int ParentPin__Offset;
		/// <summary>The pin that was split and generated this pin</summary>
		public UEdGraphPin_Deprecated ParentPin
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentPin__Offset); if (v == IntPtr.Zero)return null; UEdGraphPin_Deprecated retValue = new UEdGraphPin_Deprecated(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReferencePassThroughConnection__Offset;
		/// <summary>Pin that this pin uses for passing through reference connection</summary>
		public UEdGraphPin_Deprecated ReferencePassThroughConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReferencePassThroughConnection__Offset); if (v == IntPtr.Zero)return null; UEdGraphPin_Deprecated retValue = new UEdGraphPin_Deprecated(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bHidden__Offset;
		/// <summary>If true, this connector is currently hidden.</summary>
		public bool bHidden
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidden__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bNotConnectable__Offset;
		/// <summary>If true, this connector is unconnectable, and present only to allow the editing of the default text.</summary>
		public bool bNotConnectable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotConnectable__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDefaultValueIsReadOnly__Offset;
		/// <summary>If true, the default value of this connector is fixed and cannot be modified by the user (it's visible for reference only)</summary>
		public bool bDefaultValueIsReadOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultValueIsReadOnly__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDefaultValueIsIgnored__Offset;
		/// <summary>If true, the default value on this pin is ignored and should not be set</summary>
		public bool bDefaultValueIsIgnored
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultValueIsIgnored__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIsDiffing__Offset;
		/// <summary>If true, this pin is the focus of a diff</summary>
		public bool bIsDiffing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsDiffing__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bAdvancedView__Offset;
		/// <summary>If true, the pin may be hidden by user</summary>
		public bool bAdvancedView
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAdvancedView__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bDisplayAsMutableRef__Offset;
		/// <summary>If true, the pin is displayed as ref</summary>
		public bool bDisplayAsMutableRef
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisplayAsMutableRef__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int PersistentGuid__Offset;
		/// <summary>Pin name could be changed, so whenever possible it's good to have a persistent GUID identifying Pin to reconstruct Node seamlessly</summary>
		public FGuid PersistentGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+PersistentGuid__Offset, typeof(FGuid));}
			
		}
		
		static UEdGraphPin_Deprecated()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EdGraphPin_Deprecated");
			PinName__Offset=GetPropertyOffset(NativeClassPtr,"PinName");
			PinFriendlyName__Offset=GetPropertyOffset(NativeClassPtr,"PinFriendlyName");
			PinToolTip__Offset=GetPropertyOffset(NativeClassPtr,"PinToolTip");
			Direction__Offset=GetPropertyOffset(NativeClassPtr,"Direction");
			PinType__Offset=GetPropertyOffset(NativeClassPtr,"PinType");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			AutogeneratedDefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"AutogeneratedDefaultValue");
			DefaultObject__Offset=GetPropertyOffset(NativeClassPtr,"DefaultObject");
			DefaultTextValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTextValue");
			LinkedTo__Offset=GetPropertyOffset(NativeClassPtr,"LinkedTo");
			SubPins__Offset=GetPropertyOffset(NativeClassPtr,"SubPins");
			ParentPin__Offset=GetPropertyOffset(NativeClassPtr,"ParentPin");
			ReferencePassThroughConnection__Offset=GetPropertyOffset(NativeClassPtr,"ReferencePassThroughConnection");
			bHidden__Offset=GetPropertyOffset(NativeClassPtr,"bHidden");
			bNotConnectable__Offset=GetPropertyOffset(NativeClassPtr,"bNotConnectable");
			bDefaultValueIsReadOnly__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultValueIsReadOnly");
			bDefaultValueIsIgnored__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultValueIsIgnored");
			bIsDiffing__Offset=GetPropertyOffset(NativeClassPtr,"bIsDiffing");
			bAdvancedView__Offset=GetPropertyOffset(NativeClassPtr,"bAdvancedView");
			bDisplayAsMutableRef__Offset=GetPropertyOffset(NativeClassPtr,"bDisplayAsMutableRef");
			PersistentGuid__Offset=GetPropertyOffset(NativeClassPtr,"PersistentGuid");
			
		}
		
	}
	
}
#endif
#endif
