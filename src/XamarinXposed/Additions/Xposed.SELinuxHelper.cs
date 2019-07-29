using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='SELinuxHelper']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/SELinuxHelper", DoNotGenerateAcw=true)]
	public sealed partial class SELinuxHelper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/SELinuxHelper", typeof (SELinuxHelper));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal SELinuxHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Xposed.Services.BaseService AppDataFileService {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='SELinuxHelper']/method[@name='getAppDataFileService' and count(parameter)=0]"
			[Register ("getAppDataFileService", "()Lde/robv/android/xposed/services/BaseService;", "GetGetAppDataFileServiceHandler")]
			get {
				const string __id = "getAppDataFileService.()Lde/robv/android/xposed/services/BaseService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='SELinuxHelper']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Ljava/lang/String;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsSELinuxEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='SELinuxHelper']/method[@name='isSELinuxEnabled' and count(parameter)=0]"
			[Register ("isSELinuxEnabled", "()Z", "GetIsSELinuxEnabledHandler")]
			get {
				const string __id = "isSELinuxEnabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsSELinuxEnforced {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='SELinuxHelper']/method[@name='isSELinuxEnforced' and count(parameter)=0]"
			[Register ("isSELinuxEnforced", "()Z", "GetIsSELinuxEnforcedHandler")]
			get {
				const string __id = "isSELinuxEnforced.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
