using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LayoutInflated", DoNotGenerateAcw=true)]
	public abstract partial class XC_LayoutInflated : global::Xposed.Callbacks.XCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.LayoutInflatedParam']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam", DoNotGenerateAcw=true)]
		public sealed partial class LayoutInflatedParam : global::Xposed.Callbacks.XCallback.Param {



			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.LayoutInflatedParam']/field[@name='res']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.LayoutInflatedParam']/field[@name='resNames']"
			[Register ("resNames")]
			public global::Android.Content.Res.XResources.ResourceNames ResNames {
				get {
					const string __id = "resNames.Landroid/content/res/XResources$ResourceNames;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.ResourceNames> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "resNames.Landroid/content/res/XResources$ResourceNames;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.LayoutInflatedParam']/field[@name='variant']"
			[Register ("variant")]
			public string Variant {
				get {
					const string __id = "variant.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "variant.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.LayoutInflatedParam']/field[@name='view']"
			[Register ("view")]
			public global::Android.Views.View View {
				get {
					const string __id = "view.Landroid/view/View;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "view.Landroid/view/View;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam", typeof (LayoutInflatedParam));
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

			internal LayoutInflatedParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.Unhook']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook", DoNotGenerateAcw=true)]
		public partial class Unhook : global::Java.Lang.Object, global::Xposed.Callbacks.IXUnhook {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook", typeof (Unhook));
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

			protected Unhook (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getCallback;
#pragma warning disable 0169
			static Delegate GetGetCallbackHandler ()
			{
				if (cb_getCallback == null)
					cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
				return cb_getCallback;
			}

			static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
			{
				global::Xposed.Callbacks.XC_LayoutInflated.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Callback);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object Callback {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.Unhook']/method[@name='getCallback' and count(parameter)=0]"
				[Register ("getCallback", "()Lde/robv/android/xposed/callbacks/XC_LayoutInflated;", "GetGetCallbackHandler")]
				get {
					const string __id = "getCallback.()Lde/robv/android/xposed/callbacks/XC_LayoutInflated;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
				return cb_getId;
			}

			static int n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				global::Xposed.Callbacks.XC_LayoutInflated.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Id;
			}
#pragma warning restore 0169

			public virtual unsafe int Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.Unhook']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()I", "GetGetIdHandler")]
				get {
					const string __id = "getId.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_unhook;
#pragma warning disable 0169
			static Delegate GetUnHookHandler ()
			{
				if (cb_unhook == null)
					cb_unhook = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnHook);
				return cb_unhook;
			}

			static void n_UnHook (IntPtr jnienv, IntPtr native__this)
			{
				global::Xposed.Callbacks.XC_LayoutInflated.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UnHook ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated.Unhook']/method[@name='unhook' and count(parameter)=0]"
			[Register ("unhook", "()V", "GetUnHookHandler")]
			public virtual unsafe void UnHook ()
			{
				const string __id = "unhook.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Xposed.Callbacks.IXUnhook
			global::Java.Lang.Object global::Xposed.Callbacks.IXUnhook.Callback {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']/method[@name='getCallback' and count(parameter)=0]"
				[Register ("getCallback", "()Ljava/lang/Object;", "GetGetCallbackHandler:Xposed.Callbacks.IXUnhookInvoker, XamarinXposed")] get {
					return Callback;
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XC_LayoutInflated", typeof (XC_LayoutInflated));
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

		protected XC_LayoutInflated (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated']/constructor[@name='XC_LayoutInflated' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XC_LayoutInflated ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated']/constructor[@name='XC_LayoutInflated' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe XC_LayoutInflated (int priority)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (priority);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_handleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_;
#pragma warning disable 0169
		static Delegate GetHandleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_Handler ()
		{
			if (cb_handleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_ == null)
				cb_handleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_);
			return cb_handleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_;
		}

		static void n_HandleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.Callbacks.XC_LayoutInflated __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LayoutInflated.LayoutInflatedParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.LayoutInflatedParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLayoutInflated (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated']/method[@name='handleLayoutInflated' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated.LayoutInflatedParam']]"
		[Register ("handleLayoutInflated", "(Lde/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam;)V", "GetHandleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_Handler")]
		public abstract void HandleLayoutInflated (global::Xposed.Callbacks.XC_LayoutInflated.LayoutInflatedParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XC_LayoutInflated", DoNotGenerateAcw=true)]
	internal partial class XC_LayoutInflatedInvoker : XC_LayoutInflated {

		public XC_LayoutInflatedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/XC_LayoutInflated", typeof (XC_LayoutInflatedInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XC_LayoutInflated']/method[@name='handleLayoutInflated' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated.LayoutInflatedParam']]"
		[Register ("handleLayoutInflated", "(Lde/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam;)V", "GetHandleLayoutInflated_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_LayoutInflatedParam_Handler")]
		public override unsafe void HandleLayoutInflated (global::Xposed.Callbacks.XC_LayoutInflated.LayoutInflatedParam p0)
		{
			const string __id = "handleLayoutInflated.(Lde/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
