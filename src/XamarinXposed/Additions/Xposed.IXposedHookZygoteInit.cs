using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='IXposedHookZygoteInit.StartupParam']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/IXposedHookZygoteInit$StartupParam", DoNotGenerateAcw=true)]
	public sealed partial class XposedHookZygoteInitStartupParam : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='IXposedHookZygoteInit.StartupParam']/field[@name='modulePath']"
		[Register ("modulePath")]
		public string ModulePath {
			get {
				const string __id = "modulePath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "modulePath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='IXposedHookZygoteInit.StartupParam']/field[@name='startsSystemServer']"
		[Register ("startsSystemServer")]
		public bool StartsSystemServer {
			get {
				const string __id = "startsSystemServer.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "startsSystemServer.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/IXposedHookZygoteInit$StartupParam", typeof (XposedHookZygoteInitStartupParam));
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

		internal XposedHookZygoteInitStartupParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookZygoteInit']"
	[Register ("de/robv/android/xposed/IXposedHookZygoteInit", "", "Xposed.IXposedHookZygoteInitInvoker")]
	public partial interface IXposedHookZygoteInit : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/interface[@name='IXposedHookZygoteInit']/method[@name='initZygote' and count(parameter)=1 and parameter[1][@type='de.robv.android.xposed.IXposedHookZygoteInit.StartupParam']]"
		[Register ("initZygote", "(Lde/robv/android/xposed/IXposedHookZygoteInit$StartupParam;)V", "GetInitZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_Handler:Xposed.IXposedHookZygoteInitInvoker, XamarinXposed")]
		void InitZygote (global::Xposed.XposedHookZygoteInitStartupParam p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/IXposedHookZygoteInit", DoNotGenerateAcw=true)]
	internal class IXposedHookZygoteInitInvoker : global::Java.Lang.Object, IXposedHookZygoteInit {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/IXposedHookZygoteInit", typeof (IXposedHookZygoteInitInvoker));

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

		public static IXposedHookZygoteInit GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXposedHookZygoteInit> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.robv.android.xposed.IXposedHookZygoteInit"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXposedHookZygoteInitInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_;
#pragma warning disable 0169
		static Delegate GetInitZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_Handler ()
		{
			if (cb_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_ == null)
				cb_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_);
			return cb_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_;
		}

		static void n_InitZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.IXposedHookZygoteInit __this = global::Java.Lang.Object.GetObject<global::Xposed.IXposedHookZygoteInit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.XposedHookZygoteInitStartupParam p0 = global::Java.Lang.Object.GetObject<global::Xposed.XposedHookZygoteInitStartupParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitZygote (p0);
		}
#pragma warning restore 0169

		IntPtr id_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_;
		public unsafe void InitZygote (global::Xposed.XposedHookZygoteInitStartupParam p0)
		{
			if (id_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_ == IntPtr.Zero)
				id_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_ = JNIEnv.GetMethodID (class_ref, "initZygote", "(Lde/robv/android/xposed/IXposedHookZygoteInit$StartupParam;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initZygote_Lde_robv_android_xposed_IXposedHookZygoteInit_StartupParam_, __args);
		}

	}

}
