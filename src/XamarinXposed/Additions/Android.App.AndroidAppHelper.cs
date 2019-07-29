using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']"
	[global::Android.Runtime.Register ("android/app/AndroidAppHelper", DoNotGenerateAcw=true)]
	public sealed partial class AndroidAppHelper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/app/AndroidAppHelper", typeof (AndroidAppHelper));
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

		internal AndroidAppHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='currentApplication' and count(parameter)=0]"
		[Register ("currentApplication", "()Landroid/app/Application;", "")]
		public static unsafe global::Android.App.Application CurrentApplication ()
		{
			const string __id = "currentApplication.()Landroid/app/Application;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.App.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='currentApplicationInfo' and count(parameter)=0]"
		[Register ("currentApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", "")]
		public static unsafe global::Android.Content.PM.ApplicationInfo CurrentApplicationInfo ()
		{
			const string __id = "currentApplicationInfo.()Landroid/content/pm/ApplicationInfo;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='currentPackageName' and count(parameter)=0]"
		[Register ("currentPackageName", "()Ljava/lang/String;", "")]
		public static unsafe string CurrentPackageName ()
		{
			const string __id = "currentPackageName.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='currentProcessName' and count(parameter)=0]"
		[Register ("currentProcessName", "()Ljava/lang/String;", "")]
		public static unsafe string CurrentProcessName ()
		{
			const string __id = "currentProcessName.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='getDefaultSharedPreferencesForPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("getDefaultSharedPreferencesForPackage", "(Ljava/lang/String;)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences GetDefaultSharedPreferencesForPackage (string packageName)
		{
			const string __id = "getDefaultSharedPreferencesForPackage.(Ljava/lang/String;)Landroid/content/SharedPreferences;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='getSharedPreferencesForPackage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getSharedPreferencesForPackage", "(Ljava/lang/String;Ljava/lang/String;I)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences GetSharedPreferencesForPackage (string packageName, string prefFileName, int mode)
		{
			const string __id = "getSharedPreferencesForPackage.(Ljava/lang/String;Ljava/lang/String;I)Landroid/content/SharedPreferences;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_prefFileName = JNIEnv.NewString (prefFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_prefFileName);
				__args [2] = new JniArgumentValue (mode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_prefFileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/class[@name='AndroidAppHelper']/method[@name='reloadSharedPreferencesIfNeeded' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences']]"
		[Obsolete (@"deprecated")]
		[Register ("reloadSharedPreferencesIfNeeded", "(Landroid/content/SharedPreferences;)V", "")]
		public static unsafe void ReloadSharedPreferencesIfNeeded (global::Android.Content.ISharedPreferences pref)
		{
			const string __id = "reloadSharedPreferencesIfNeeded.(Landroid/content/SharedPreferences;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pref).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
