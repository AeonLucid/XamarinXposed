using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodReplacement", DoNotGenerateAcw=true)]
	public abstract partial class XC_MethodReplacement : global::Xposed.XC_MethodHook {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/field[@name='DO_NOTHING']"
		[Register ("DO_NOTHING")]
		public static global::Xposed.XC_MethodReplacement DoNothing {
			get {
				const string __id = "DO_NOTHING.Lde/robv/android/xposed/XC_MethodReplacement;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodReplacement> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XC_MethodReplacement", typeof (XC_MethodReplacement));
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

		protected XC_MethodReplacement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/constructor[@name='XC_MethodReplacement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XC_MethodReplacement ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/constructor[@name='XC_MethodReplacement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe XC_MethodReplacement (int priority)
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

		static Delegate cb_replaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
#pragma warning disable 0169
		static Delegate GetReplaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler ()
		{
			if (cb_replaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ == null)
				cb_replaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReplaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_);
			return cb_replaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_;
		}

		static IntPtr n_ReplaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.XC_MethodReplacement __this = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodReplacement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.XC_MethodHook.MethodHookParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.MethodHookParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReplaceHookedMethod (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/method[@name='replaceHookedMethod' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.XC_MethodHook.MethodHookParam']]"
		[Register ("replaceHookedMethod", "(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)Ljava/lang/Object;", "GetReplaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler")]
		protected abstract global::Java.Lang.Object ReplaceHookedMethod (global::Xposed.XC_MethodHook.MethodHookParam p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/method[@name='returnConstant' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("returnConstant", "(ILjava/lang/Object;)Lde/robv/android/xposed/XC_MethodReplacement;", "")]
		public static unsafe global::Xposed.XC_MethodReplacement ReturnConstant (int priority, global::Java.Lang.Object result)
		{
			const string __id = "returnConstant.(ILjava/lang/Object;)Lde/robv/android/xposed/XC_MethodReplacement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodReplacement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/method[@name='returnConstant' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("returnConstant", "(Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodReplacement;", "")]
		public static unsafe global::Xposed.XC_MethodReplacement ReturnConstant (global::Java.Lang.Object result)
		{
			const string __id = "returnConstant.(Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodReplacement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodReplacement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/XC_MethodReplacement", DoNotGenerateAcw=true)]
	internal partial class XC_MethodReplacementInvoker : XC_MethodReplacement {

		public XC_MethodReplacementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/XC_MethodReplacement", typeof (XC_MethodReplacementInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XC_MethodReplacement']/method[@name='replaceHookedMethod' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.XC_MethodHook.MethodHookParam']]"
		[Register ("replaceHookedMethod", "(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)Ljava/lang/Object;", "GetReplaceHookedMethod_Lde_robv_android_xposed_XC_MethodHook_MethodHookParam_Handler")]
		protected override unsafe global::Java.Lang.Object ReplaceHookedMethod (global::Xposed.XC_MethodHook.MethodHookParam p0)
		{
			const string __id = "replaceHookedMethod.(Lde/robv/android/xposed/XC_MethodHook$MethodHookParam;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
