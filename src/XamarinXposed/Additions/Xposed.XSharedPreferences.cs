using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/XSharedPreferences", DoNotGenerateAcw=true)]
	public sealed partial class XSharedPreferences : global::Java.Lang.Object, global::Android.Content.ISharedPreferences {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XSharedPreferences", typeof (XSharedPreferences));
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

		internal XSharedPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/constructor[@name='XSharedPreferences' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe XSharedPreferences (global::Java.IO.File prefFile)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((prefFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prefFile).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/constructor[@name='XSharedPreferences' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe XSharedPreferences (string packageName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/constructor[@name='XSharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe XSharedPreferences (string packageName, string prefFileName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_packageName = JNIEnv.NewString (packageName);
			IntPtr native_prefFileName = JNIEnv.NewString (prefFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_prefFileName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				JNIEnv.DeleteLocalRef (native_prefFileName);
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, object> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.IO.File File {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getFile' and count(parameter)=0]"
			[Register ("getFile", "()Ljava/io/File;", "GetGetFileHandler")]
			get {
				const string __id = "getFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool HasFileChanged {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='hasFileChanged' and count(parameter)=0]"
			[Register ("hasFileChanged", "()Z", "GetHasFileChangedHandler")]
			get {
				const string __id = "hasFileChanged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Contains (string key)
		{
			const string __id = "contains.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='edit' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("edit", "()Landroid/content/SharedPreferences$Editor;", "")]
		public unsafe global::Android.Content.ISharedPreferencesEditor Edit ()
		{
			const string __id = "edit.()Landroid/content/SharedPreferences$Editor;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferencesEditor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "")]
		public unsafe bool GetBoolean (string key, bool defValue)
		{
			const string __id = "getBoolean.(Ljava/lang/String;Z)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (defValue);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloat", "(Ljava/lang/String;F)F", "")]
		public unsafe float GetFloat (string key, float defValue)
		{
			const string __id = "getFloat.(Ljava/lang/String;F)F";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (defValue);
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "")]
		public unsafe int GetInt (string key, int defValue)
		{
			const string __id = "getInt.(Ljava/lang/String;I)I";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (defValue);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;J)J", "")]
		public unsafe long GetLong (string key, long defValue)
		{
			const string __id = "getLong.(Ljava/lang/String;J)J";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (defValue);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetString (string key, string defValue)
		{
			const string __id = "getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_defValue = JNIEnv.NewString (defValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_defValue);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='getStringSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> GetStringSet (string key, global::System.Collections.Generic.ICollection<string> defValues)
		{
			const string __id = "getStringSet.(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_defValues = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (defValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_defValues);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defValues);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='makeWorldReadable' and count(parameter)=0]"
		[Register ("makeWorldReadable", "()Z", "")]
		public unsafe bool MakeWorldReadable ()
		{
			const string __id = "makeWorldReadable.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='registerOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences.OnSharedPreferenceChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", "")]
		public unsafe void RegisterOnSharedPreferenceChangeListener (global::Android.Content.ISharedPreferencesOnSharedPreferenceChangeListener listener)
		{
			const string __id = "registerOnSharedPreferenceChangeListener.(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='reload' and count(parameter)=0]"
		[Register ("reload", "()V", "")]
		public unsafe void Reload ()
		{
			const string __id = "reload.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XSharedPreferences']/method[@name='unregisterOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences.OnSharedPreferenceChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", "")]
		public unsafe void UnregisterOnSharedPreferenceChangeListener (global::Android.Content.ISharedPreferencesOnSharedPreferenceChangeListener listener)
		{
			const string __id = "unregisterOnSharedPreferenceChangeListener.(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
