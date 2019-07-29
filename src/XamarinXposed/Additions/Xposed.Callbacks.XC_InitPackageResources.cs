using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_InitPackageResources']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_InitPackageResources", DoNotGenerateAcw=true)]
	public abstract partial class XC_InitPackageResources : global::Xposed.Callbacks.XCallback, global::Xposed.IXposedHookInitPackageResources {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_InitPackageResources.InitPackageResourcesParam']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam", DoNotGenerateAcw=true)]
		public sealed partial class InitPackageResourcesParam : global::Xposed.Callbacks.XCallback.Param {



			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_InitPackageResources.InitPackageResourcesParam']/field[@name='packageName']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_InitPackageResources.InitPackageResourcesParam']/field[@name='res']"
			[Register ("res")]
			public global::Android.Content.Res.XResources Res {
				get {
					const string __id = "res.Landroid/content/res/XResources;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "res.Landroid/content/res/XResources;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam", typeof (InitPackageResourcesParam));
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

			internal InitPackageResourcesParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_InitPackageResources", typeof (XC_InitPackageResources));
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

		protected XC_InitPackageResources (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_;
#pragma warning disable 0169
		static Delegate GetHandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_Handler ()
		{
			if (cb_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_ == null)
				cb_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_);
			return cb_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_;
		}

		static void n_HandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.Callbacks.XC_InitPackageResources __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_InitPackageResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleInitPackageResources (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookInitPackageResources']/method[@name='handleInitPackageResources' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_InitPackageResources.InitPackageResourcesParam']]"
		[Register ("handleInitPackageResources", "(Lde/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam;)V", "GetHandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_Handler")]
		public abstract void HandleInitPackageResources (global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_InitPackageResources", DoNotGenerateAcw=true)]
	internal partial class XC_InitPackageResourcesInvoker : XC_InitPackageResources {

		public XC_InitPackageResourcesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/XC_InitPackageResources", typeof (XC_InitPackageResourcesInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookInitPackageResources']/method[@name='handleInitPackageResources' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_InitPackageResources.InitPackageResourcesParam']]"
		[Register ("handleInitPackageResources", "(Lde/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam;)V", "GetHandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_Handler")]
		public override unsafe void HandleInitPackageResources (global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0)
		{
			const string __id = "handleInitPackageResources.(Lde/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
