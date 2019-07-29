using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookInitPackageResources']"
	[Register ("de/robv/android/xposed/IXposedHookInitPackageResources", "", "Xposed.IXposedHookInitPackageResourcesInvoker")]
	public partial interface IXposedHookInitPackageResources : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookInitPackageResources']/method[@name='handleInitPackageResources' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_InitPackageResources.InitPackageResourcesParam']]"
		[Register ("handleInitPackageResources", "(Lde/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam;)V", "GetHandleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_Handler:Xposed.IXposedHookInitPackageResourcesInvoker, XamarinXposed")]
		void HandleInitPackageResources (global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/IXposedHookInitPackageResources", DoNotGenerateAcw=true)]
	internal class IXposedHookInitPackageResourcesInvoker : global::Java.Lang.Object, IXposedHookInitPackageResources {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/IXposedHookInitPackageResources", typeof (IXposedHookInitPackageResourcesInvoker));

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

		public static IXposedHookInitPackageResources GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXposedHookInitPackageResources> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.robv.android.xposed.IXposedHookInitPackageResources"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXposedHookInitPackageResourcesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Xposed.IXposedHookInitPackageResources __this = global::Java.Lang.Object.GetObject<global::Xposed.IXposedHookInitPackageResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleInitPackageResources (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_;
		public unsafe void HandleInitPackageResources (global::Xposed.Callbacks.XC_InitPackageResources.InitPackageResourcesParam p0)
		{
			if (id_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_ == IntPtr.Zero)
				id_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_ = JNIEnv.GetMethodID (class_ref, "handleInitPackageResources", "(Lde/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleInitPackageResources_Lde_robv_android_xposed_callbacks_XC_InitPackageResources_InitPackageResourcesParam_, __args);
		}

	}

}
