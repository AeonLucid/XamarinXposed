using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LoadPackage", DoNotGenerateAcw=true)]
	public abstract partial class XC_LoadPackage : global::Xposed.Callbacks.XCallback, global::Xposed.IXposedHookLoadPackage {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam", DoNotGenerateAcw=true)]
		public sealed partial class LoadPackageParam : global::Xposed.Callbacks.XCallback.Param {



			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']/field[@name='appInfo']"
			[Register ("appInfo")]
			public global::Android.Content.PM.ApplicationInfo AppInfo {
				get {
					const string __id = "appInfo.Landroid/content/pm/ApplicationInfo;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "appInfo.Landroid/content/pm/ApplicationInfo;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']/field[@name='classLoader']"
			[Register ("classLoader")]
			public global::Java.Lang.ClassLoader ClassLoader {
				get {
					const string __id = "classLoader.Ljava/lang/ClassLoader;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "classLoader.Ljava/lang/ClassLoader;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']/field[@name='isFirstApplication']"
			[Register ("isFirstApplication")]
			public bool IsFirstApplication {
				get {
					const string __id = "isFirstApplication.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isFirstApplication.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']/field[@name='packageName']"
			[Register ("packageName")]
			public string PackageName {
				get {
					const string __id = "packageName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "packageName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LoadPackage.LoadPackageParam']/field[@name='processName']"
			[Register ("processName")]
			public string ProcessName {
				get {
					const string __id = "processName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "processName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam", typeof (LoadPackageParam));
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

			internal LoadPackageParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_LoadPackage", typeof (XC_LoadPackage));
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

		protected XC_LoadPackage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_;
#pragma warning disable 0169
		static Delegate GetHandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_Handler ()
		{
			if (cb_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_ == null)
				cb_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_);
			return cb_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_;
		}

		static void n_HandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.Callbacks.XC_LoadPackage __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LoadPackage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLoadPackage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookLoadPackage']/method[@name='handleLoadPackage' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_LoadPackage.LoadPackageParam']]"
		[Register ("handleLoadPackage", "(Lde/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam;)V", "GetHandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_Handler")]
		public abstract void HandleLoadPackage (global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LoadPackage", DoNotGenerateAcw=true)]
	internal partial class XC_LoadPackageInvoker : XC_LoadPackage {

		public XC_LoadPackageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/XC_LoadPackage", typeof (XC_LoadPackageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookLoadPackage']/method[@name='handleLoadPackage' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_LoadPackage.LoadPackageParam']]"
		[Register ("handleLoadPackage", "(Lde/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam;)V", "GetHandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_Handler")]
		public override unsafe void HandleLoadPackage (global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0)
		{
			const string __id = "handleLoadPackage.(Lde/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
