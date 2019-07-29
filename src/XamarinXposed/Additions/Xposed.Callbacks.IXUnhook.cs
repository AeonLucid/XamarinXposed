using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']"
	[Register ("de/robv/android/xposed/callbacks/IXUnhook", "", "Xposed.Callbacks.IXUnhookInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IXUnhook : IJavaObject {

		global::Java.Lang.Object Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Ljava/lang/Object;", "GetGetCallbackHandler:Xposed.Callbacks.IXUnhookInvoker, XamarinXposed")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']/method[@name='unhook' and count(parameter)=0]"
		[Register ("unhook", "()V", "GetUnHookHandler:Xposed.Callbacks.IXUnhookInvoker, XamarinXposed")]
		void UnHook ();

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/callbacks/IXUnhook", DoNotGenerateAcw=true)]
	internal class IXUnhookInvoker : global::Java.Lang.Object, IXUnhook {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/callbacks/IXUnhook", typeof (IXUnhookInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IXUnhook GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXUnhook> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.robv.android.xposed.callbacks.IXUnhook"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXUnhookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Xposed.Callbacks.IXUnhook __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.IXUnhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		IntPtr id_getCallback;
		public unsafe global::Java.Lang.Object Callback {
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
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
			global::Xposed.Callbacks.IXUnhook __this = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.IXUnhook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnHook ();
		}
#pragma warning restore 0169

		IntPtr id_unhook;
		public unsafe void UnHook ()
		{
			if (id_unhook == IntPtr.Zero)
				id_unhook = JNIEnv.GetMethodID (class_ref, "unhook", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unhook);
		}

	}

}
