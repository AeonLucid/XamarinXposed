using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodHook", DoNotGenerateAcw=true)]
	public abstract partial class XC_MethodHook : global::Xposed.Callbacks.XCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodHook$MethodHookParam", DoNotGenerateAcw=true)]
		public sealed partial class MethodHookParam : global::Xposed.Callbacks.XCallback.Param {



			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/field[@name='args']"
			[Register ("args")]
			public IList<Java.Lang.Object> Args {
				get {
					const string __id = "args.[Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "args.[Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/field[@name='method']"
			[Register ("method")]
			public global::Java.Lang.Reflect.IMember Method {
				get {
					const string __id = "method.Ljava/lang/reflect/Member;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IMember> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "method.Ljava/lang/reflect/Member;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/field[@name='thisObject']"
			[Register ("thisObject")]
			public global::Java.Lang.Object ThisObject {
				get {
					const string __id = "thisObject.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "thisObject.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XC_MethodHook$MethodHookParam", typeof (MethodHookParam));
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

			internal MethodHookParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe bool HasThrowable {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='hasThrowable' and count(parameter)=0]"
				[Register ("hasThrowable", "()Z", "GetHasThrowableHandler")]
				get {
					const string __id = "hasThrowable.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Object Result {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='getResult' and count(parameter)=0]"
				[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
				get {
					const string __id = "getResult.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
				[Register ("setResult", "(Ljava/lang/Object;)V", "GetSetResult_Ljava_lang_Object_Handler")]
				set {
					const string __id = "setResult.(Ljava/lang/Object;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Object ResultOrThrowable {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='getResultOrThrowable' and count(parameter)=0]"
				[Register ("getResultOrThrowable", "()Ljava/lang/Object;", "GetGetResultOrThrowableHandler")]
				get {
					const string __id = "getResultOrThrowable.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Throwable Throwable {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='getThrowable' and count(parameter)=0]"
				[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
				get {
					const string __id = "getThrowable.()Ljava/lang/Throwable;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.MethodHookParam']/method[@name='setThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
				[Register ("setThrowable", "(Ljava/lang/Throwable;)V", "GetSetThrowable_Ljava_lang_Throwable_Handler")]
				set {
					const string __id = "setThrowable.(Ljava/lang/Throwable;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) value).Handle);
						_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.Unhook']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodHook$Unhook", DoNotGenerateAcw=true)]
		public partial class Unhook : global::Java.Lang.Object, global::Xposed.Callbacks.IXUnhook {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XC_MethodHook$Unhook", typeof (Unhook));
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
				global::Xposed.XC_MethodHook.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Callback);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object Callback {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.Unhook']/method[@name='getCallback' and count(parameter)=0]"
				[Register ("getCallback", "()Lde/robv/android/xposed/XC_MethodHook;", "GetGetCallbackHandler")]
				get {
					const string __id = "getCallback.()Lde/robv/android/xposed/XC_MethodHook;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getHookedMethod;
#pragma warning disable 0169
			static Delegate GetGetHookedMethodHandler ()
			{
				if (cb_getHookedMethod == null)
					cb_getHookedMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHookedMethod);
				return cb_getHookedMethod;
			}

			static IntPtr n_GetHookedMethod (IntPtr jnienv, IntPtr native__this)
			{
				global::Xposed.XC_MethodHook.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.HookedMethod);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Reflect.IMember HookedMethod {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.Unhook']/method[@name='getHookedMethod' and count(parameter)=0]"
				[Register ("getHookedMethod", "()Ljava/lang/reflect/Member;", "GetGetHookedMethodHandler")]
				get {
					const string __id = "getHookedMethod.()Ljava/lang/reflect/Member;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Xposed.XC_MethodHook.Unhook __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UnHook ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook.Unhook']/method[@name='unhook' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XC_MethodHook", typeof (XC_MethodHook));
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

		protected XC_MethodHook (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook']/constructor[@name='XC_MethodHook' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XC_MethodHook ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook']/constructor[@name='XC_MethodHook' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe XC_MethodHook (int priority)
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

		static Delegate cb_afterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
#pragma warning disable 0169
		static Delegate GetAfterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler ()
		{
			if (cb_afterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ == null)
				cb_afterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_);
			return cb_afterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
		}

		static void n_AfterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_param)
		{
			global::Xposed.XC_MethodHook __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.XC_MethodHook.MethodHookParam param = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.MethodHookParam> (native_param, JniHandleOwnership.DoNotTransfer);
			__this.AfterHookedMethod (param);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook']/method[@name='afterHookedMethod' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.XC_MethodHook.MethodHookParam']]"
		[Register ("afterHookedMethod", "(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)V", "GetAfterHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler")]
		protected virtual unsafe void AfterHookedMethod (global::Xposed.XC_MethodHook.MethodHookParam param)
		{
			const string __id = "afterHookedMethod.(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((param == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_beforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
#pragma warning disable 0169
		static Delegate GetBeforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler ()
		{
			if (cb_beforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ == null)
				cb_beforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BeforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_);
			return cb_beforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
		}

		static void n_BeforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_param)
		{
			global::Xposed.XC_MethodHook __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.XC_MethodHook.MethodHookParam param = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.MethodHookParam> (native_param, JniHandleOwnership.DoNotTransfer);
			__this.BeforeHookedMethod (param);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodHook']/method[@name='beforeHookedMethod' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.XC_MethodHook.MethodHookParam']]"
		[Register ("beforeHookedMethod", "(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)V", "GetBeforeHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler")]
		protected virtual unsafe void BeforeHookedMethod (global::Xposed.XC_MethodHook.MethodHookParam param)
		{
			const string __id = "beforeHookedMethod.(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((param == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodHook", DoNotGenerateAcw=true)]
	internal partial class XC_MethodHookInvoker : XC_MethodHook {

		public XC_MethodHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/XC_MethodHook", typeof (XC_MethodHookInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
