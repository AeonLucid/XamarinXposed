using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookLoadPackage']"
	[Register ("de/robv/android/xposed/IXposedHookLoadPackage", "", "Xposed.IXposedHookLoadPackageInvoker")]
	public partial interface IXposedHookLoadPackage : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookLoadPackage']/method[@name='handleLoadPackage' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.callbacks.XC_LoadPackage.LoadPackageParam']]"
		[Register ("handleLoadPackage", "(Lde/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam;)V", "GetHandleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_Handler:Xposed.IXposedHookLoadPackageInvoker, XamarinXposed")]
		void HandleLoadPackage (global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/IXposedHookLoadPackage", DoNotGenerateAcw=true)]
	internal class IXposedHookLoadPackageInvoker : global::Java.Lang.Object, IXposedHookLoadPackage {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/IXposedHookLoadPackage", typeof (IXposedHookLoadPackageInvoker));

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

		public static IXposedHookLoadPackage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXposedHookLoadPackage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.robv.android.xposed.IXposedHookLoadPackage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXposedHookLoadPackageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Xposed.IXposedHookLoadPackage __this = global::Java.Lang.Object.GetObject<global::Xposed.IXposedHookLoadPackage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLoadPackage (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_;
		public unsafe void HandleLoadPackage (global::Xposed.Callbacks.XC_LoadPackage.LoadPackageParam p0)
		{
			if (id_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_ == IntPtr.Zero)
				id_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_ = JNIEnv.GetMethodID (class_ref, "handleLoadPackage", "(Lde/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleLoadPackage_Lde_robv_android_xposed_callbacks_XC_LoadPackage_LoadPackageParam_, __args);
		}

	}

}
