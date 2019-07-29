using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content.Res {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XResForwarder']"
	[global::Android.Runtime.Register ("android/content/res/XResForwarder", DoNotGenerateAcw=true)]
	public partial class XResForwarder : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XResForwarder", typeof (XResForwarder));
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

		protected XResForwarder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.content.res']/class[@name='XResForwarder']/constructor[@name='XResForwarder' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/res/Resources;I)V", "")]
		public unsafe XResForwarder (global::Android.Content.Res.Resources res, int id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue (id);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Android.Content.Res.XResForwarder __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResForwarder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResForwarder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Res.XResForwarder __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResForwarder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResForwarder']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				const string __id = "getResources.()Landroid/content/res/Resources;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
