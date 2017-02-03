#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>UObject based class for handling mobile events. Having this object as an option gives the app lifetime access to these global delegates. The component UApplicationLifecycleComponent is destroyed at level loads</summary>
	public partial class UPlatformGameInstance
	{
		static readonly int ApplicationWillDeactivateDelegate__Offset;
		/// <summary>
		/// This is called when the application is about to be deactivated (e.g., due to a phone call or SMS or the sleep button).
		/// The game should be paused if possible, etc...
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillDeactivateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillDeactivateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillDeactivateDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasReactivatedDelegate__Offset;
		/// <summary>Called when the application has been reactivated (reverse any processing done in the Deactivate delegate)</summary>
		public FMulticastScriptDelegate ApplicationHasReactivatedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasReactivatedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasReactivatedDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillEnterBackgroundDelegate__Offset;
		/// <summary>
		/// This is called when the application is being backgrounded (e.g., due to switching
		/// to another app or closing it via the home button)
		/// The game should release shared resources, save state, etc..., since it can be
		/// terminated from the background state without any further warning.
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillEnterBackgroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasEnteredForegroundDelegate__Offset;
		/// <summary>Called when the application is returning to the foreground (reverse any processing done in the EnterBackground delegate)</summary>
		public FMulticastScriptDelegate ApplicationHasEnteredForegroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillTerminateDelegate__Offset;
		/// <summary>
		/// This *may* be called when the application is getting terminated by the OS.
		/// There is no guarantee that this will ever be called on a mobile device,
		/// save state when ApplicationWillEnterBackgroundDelegate is called instead.
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillTerminateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillTerminateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillTerminateDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationRegisteredForRemoteNotificationsDelegate__Offset;
		/// <summary>called when the user grants permission to register for remote notifications</summary>
		public FMulticastScriptDelegate ApplicationRegisteredForRemoteNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationRegisteredForRemoteNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationRegisteredForRemoteNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationRegisteredForUserNotificationsDelegate__Offset;
		/// <summary>called when the user grants permission to register for notifications</summary>
		public FMulticastScriptDelegate ApplicationRegisteredForUserNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationRegisteredForUserNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationRegisteredForUserNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset;
		/// <summary>called when the application fails to register for remote notifications</summary>
		public FMulticastScriptDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedRemoteNotificationDelegate__Offset;
		/// <summary>called when the application receives a remote notification</summary>
		public FMulticastScriptDelegate ApplicationReceivedRemoteNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedRemoteNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedRemoteNotificationDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedLocalNotificationDelegate__Offset;
		/// <summary>called when the application receives a local notification</summary>
		public FMulticastScriptDelegate ApplicationReceivedLocalNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedLocalNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedLocalNotificationDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset;
		/// <summary>called when the application receives a screen orientation change notification</summary>
		public FMulticastScriptDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset, false);}
			
		}
		
		static UPlatformGameInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlatformGameInstance");
			ApplicationWillDeactivateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillDeactivateDelegate");
			ApplicationHasReactivatedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasReactivatedDelegate");
			ApplicationWillEnterBackgroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillEnterBackgroundDelegate");
			ApplicationHasEnteredForegroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasEnteredForegroundDelegate");
			ApplicationWillTerminateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillTerminateDelegate");
			ApplicationRegisteredForRemoteNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationRegisteredForRemoteNotificationsDelegate");
			ApplicationRegisteredForUserNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationRegisteredForUserNotificationsDelegate");
			ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationFailedToRegisterForRemoteNotificationsDelegate");
			ApplicationReceivedRemoteNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedRemoteNotificationDelegate");
			ApplicationReceivedLocalNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedLocalNotificationDelegate");
			ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedScreenOrientationChangedNotificationDelegate");
			
		}
		
	}
	
}
#endif
#endif
