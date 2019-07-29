using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content.Res {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XModuleResources']"
	[global::Android.Runtime.Register ("android/content/res/XModuleResources", DoNotGenerateAcw=true)]
	public partial class XModuleResources : global::Android.Content.Res.Resources {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XModuleResources", typeof (XModuleResources));
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

		protected XModuleResources (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XModuleResources']/method[@name='createInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.res.XResources']]"
		[Register ("createInstance", "(Ljava/lang/String;Landroid/content/res/XResources;)Landroid/content/res/XModuleResources;", "")]
		public static unsafe global::Android.Content.Res.XModuleResources CreateInstance (string path, global::Android.Content.Res.XResources origRes)
		{
			const string __id = "createInstance.(Ljava/lang/String;Landroid/content/res/XResources;)Landroid/content/res/XModuleResources;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((origRes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origRes).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.XModuleResources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_fwd_I;
#pragma warning disable 0169
		static Delegate GetFwd_IHandler ()
		{
			if (cb_fwd_I == null)
				cb_fwd_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Fwd_I);
			return cb_fwd_I;
		}

		static IntPtr n_Fwd_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Android.Content.Res.XModuleResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XModuleResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fwd (id));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XModuleResources']/method[@name='fwd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fwd", "(I)Landroid/content/res/XResForwarder;", "GetFwd_IHandler")]
		public virtual unsafe global::Android.Content.Res.XResForwarder Fwd (int id)
		{
			const string __id = "fwd.(I)Landroid/content/res/XResForwarder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResForwarder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
