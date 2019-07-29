using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XCallback", DoNotGenerateAcw=true)]
	public abstract partial class XCallback : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']/field[@name='PRIORITY_DEFAULT']"
		[Register ("PRIORITY_DEFAULT")]
		public const int PriorityDefault = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']/field[@name='PRIORITY_HIGHEST']"
		[Register ("PRIORITY_HIGHEST")]
		public const int PriorityHighest = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']/field[@name='PRIORITY_LOWEST']"
		[Register ("PRIORITY_LOWEST")]
		public const int PriorityLowest = (int) -10000;


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']/field[@name='priority']"
		[Register ("priority")]
		public int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "priority.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback.Param']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XCallback$Param", DoNotGenerateAcw=true)]
		public abstract partial class Param : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XCallback$Param", typeof (Param));
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

			protected Param (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback.Param']/constructor[@name='XCallback.Param' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			[Obsolete (@"deprecated")]
			protected unsafe Param ()
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

			static Delegate cb_getExtra;
#pragma warning disable 0169
			static Delegate GetGetExtraHandler ()
			{
				if (cb_getExtra == null)
					cb_getExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtra);
				return cb_getExtra;
			}

			static IntPtr n_GetExtra (IntPtr jnienv, IntPtr native__this)
			{
				global::Xposed.Callbacks.XCallback.Param __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XCallback.Param> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Extra);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.OS.Bundle Extra {
				// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback.Param']/method[@name='getExtra' and count(parameter)=0]"
				[Register ("getExtra", "()Landroid/os/Bundle;", "GetGetExtraHandler")]
				get {
					const string __id = "getExtra.()Landroid/os/Bundle;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getObjectExtra_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetObjectExtra_Ljava_lang_String_Handler ()
			{
				if (cb_getObjectExtra_Ljava_lang_String_ == null)
					cb_getObjectExtra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObjectExtra_Ljava_lang_String_);
				return cb_getObjectExtra_Ljava_lang_String_;
			}

			static IntPtr n_GetObjectExtra_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				global::Xposed.Callbacks.XCallback.Param __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XCallback.Param> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObjectExtra (key));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback.Param']/method[@name='getObjectExtra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getObjectExtra", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetObjectExtra_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object GetObjectExtra (string key)
			{
				const string __id = "getObjectExtra.(Ljava/lang/String;)Ljava/lang/Object;";
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static Delegate cb_setObjectExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetObjectExtra_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_setObjectExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_setObjectExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetObjectExtra_Ljava_lang_String_Ljava_lang_Object_);
				return cb_setObjectExtra_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_SetObjectExtra_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_o)
			{
				global::Xposed.Callbacks.XCallback.Param __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XCallback.Param> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				__this.SetObjectExtra (key, o);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback.Param']/method[@name='setObjectExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("setObjectExtra", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetObjectExtra_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual unsafe void SetObjectExtra (string key, global::Java.Lang.Object o)
			{
				const string __id = "setObjectExtra.(Ljava/lang/String;Ljava/lang/Object;)V";
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_key);
					__args [1] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

		}

		[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XCallback$Param", DoNotGenerateAcw=true)]
		internal partial class ParamInvoker : Param {

			public ParamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/XCallback$Param", typeof (ParamInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/callbacks/XCallback", typeof (XCallback));
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

		protected XCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/class[@name='XCallback']/constructor[@name='XCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		[Obsolete (@"deprecated")]
		public unsafe XCallback ()
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

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/XCallback", DoNotGenerateAcw=true)]
	internal partial class XCallbackInvoker : XCallback {

		public XCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/XCallback", typeof (XCallbackInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
