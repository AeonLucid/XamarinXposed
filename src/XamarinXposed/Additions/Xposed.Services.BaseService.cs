using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/services/BaseService", DoNotGenerateAcw=true)]
	public abstract partial class BaseService : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/field[@name='F_OK']"
		[Register ("F_OK")]
		public const int FOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/field[@name='R_OK']"
		[Register ("R_OK")]
		public const int ROk = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/field[@name='W_OK']"
		[Register ("W_OK")]
		public const int WOk = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/field[@name='X_OK']"
		[Register ("X_OK")]
		public const int XOk = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/services/BaseService", typeof (BaseService));
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

		protected BaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasDirectFileAccess;
#pragma warning disable 0169
		static Delegate GetHasDirectFileAccessHandler ()
		{
			if (cb_hasDirectFileAccess == null)
				cb_hasDirectFileAccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDirectFileAccess);
			return cb_hasDirectFileAccess;
		}

		static bool n_HasDirectFileAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDirectFileAccess;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasDirectFileAccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='hasDirectFileAccess' and count(parameter)=0]"
			[Register ("hasDirectFileAccess", "()Z", "GetHasDirectFileAccessHandler")]
			get {
				const string __id = "hasDirectFileAccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkFileAccess_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCheckFileAccess_Ljava_lang_String_IHandler ()
		{
			if (cb_checkFileAccess_Ljava_lang_String_I == null)
				cb_checkFileAccess_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_CheckFileAccess_Ljava_lang_String_I);
			return cb_checkFileAccess_Ljava_lang_String_I;
		}

		static bool n_CheckFileAccess_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckFileAccess (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='checkFileAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("checkFileAccess", "(Ljava/lang/String;I)Z", "GetCheckFileAccess_Ljava_lang_String_IHandler")]
		public abstract bool CheckFileAccess (string p0, int p1);

		static Delegate cb_checkFileExists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckFileExists_Ljava_lang_String_Handler ()
		{
			if (cb_checkFileExists_Ljava_lang_String_ == null)
				cb_checkFileExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CheckFileExists_Ljava_lang_String_);
			return cb_checkFileExists_Ljava_lang_String_;
		}

		static bool n_CheckFileExists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckFileExists (filename);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='checkFileExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkFileExists", "(Ljava/lang/String;)Z", "GetCheckFileExists_Ljava_lang_String_Handler")]
		public virtual unsafe bool CheckFileExists (string filename)
		{
			const string __id = "checkFileExists.(Ljava/lang/String;)Z";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_getFileInputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileInputStream_Ljava_lang_String_Handler ()
		{
			if (cb_getFileInputStream_Ljava_lang_String_ == null)
				cb_getFileInputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFileInputStream_Ljava_lang_String_);
			return cb_getFileInputStream_Ljava_lang_String_;
		}

		static IntPtr n_GetFileInputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetFileInputStream (filename));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='getFileInputStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileInputStream", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetGetFileInputStream_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.IO.Stream GetFileInputStream (string filename)
		{
			const string __id = "getFileInputStream.(Ljava/lang/String;)Ljava/io/InputStream;";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_getFileInputStream_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetGetFileInputStream_Ljava_lang_String_JJHandler ()
		{
			if (cb_getFileInputStream_Ljava_lang_String_JJ == null)
				cb_getFileInputStream_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_GetFileInputStream_Ljava_lang_String_JJ);
			return cb_getFileInputStream_Ljava_lang_String_JJ;
		}

		static IntPtr n_GetFileInputStream_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, long previousSize, long previousTime)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFileInputStream (filename, previousSize, previousTime));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='getFileInputStream' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("getFileInputStream", "(Ljava/lang/String;JJ)Lde/robv/android/xposed/services/FileResult;", "GetGetFileInputStream_Ljava_lang_String_JJHandler")]
		public virtual unsafe global::Xposed.Services.FileResult GetFileInputStream (string filename, long previousSize, long previousTime)
		{
			const string __id = "getFileInputStream.(Ljava/lang/String;JJ)Lde/robv/android/xposed/services/FileResult;";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filename);
				__args [1] = new JniArgumentValue (previousSize);
				__args [2] = new JniArgumentValue (previousTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Services.FileResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_getFileModificationTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileModificationTime_Ljava_lang_String_Handler ()
		{
			if (cb_getFileModificationTime_Ljava_lang_String_ == null)
				cb_getFileModificationTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetFileModificationTime_Ljava_lang_String_);
			return cb_getFileModificationTime_Ljava_lang_String_;
		}

		static long n_GetFileModificationTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFileModificationTime (filename);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='getFileModificationTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileModificationTime", "(Ljava/lang/String;)J", "GetGetFileModificationTime_Ljava_lang_String_Handler")]
		public virtual unsafe long GetFileModificationTime (string filename)
		{
			const string __id = "getFileModificationTime.(Ljava/lang/String;)J";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_getFileSize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileSize_Ljava_lang_String_Handler ()
		{
			if (cb_getFileSize_Ljava_lang_String_ == null)
				cb_getFileSize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetFileSize_Ljava_lang_String_);
			return cb_getFileSize_Ljava_lang_String_;
		}

		static long n_GetFileSize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFileSize (filename);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileSize", "(Ljava/lang/String;)J", "GetGetFileSize_Ljava_lang_String_Handler")]
		public virtual unsafe long GetFileSize (string filename)
		{
			const string __id = "getFileSize.(Ljava/lang/String;)J";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_readFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadFile_Ljava_lang_String_Handler ()
		{
			if (cb_readFile_Ljava_lang_String_ == null)
				cb_readFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadFile_Ljava_lang_String_);
			return cb_readFile_Ljava_lang_String_;
		}

		static IntPtr n_ReadFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ReadFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;)[B", "GetReadFile_Ljava_lang_String_Handler")]
		public abstract byte[] ReadFile (string p0);

		static Delegate cb_readFile_Ljava_lang_String_IIJJ;
#pragma warning disable 0169
		static Delegate GetReadFile_Ljava_lang_String_IIJJHandler ()
		{
			if (cb_readFile_Ljava_lang_String_IIJJ == null)
				cb_readFile_Ljava_lang_String_IIJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, long, long, IntPtr>) n_ReadFile_Ljava_lang_String_IIJJ);
			return cb_readFile_Ljava_lang_String_IIJJ;
		}

		static IntPtr n_ReadFile_Ljava_lang_String_IIJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, long p3, long p4)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadFile (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("readFile", "(Ljava/lang/String;IIJJ)Lde/robv/android/xposed/services/FileResult;", "GetReadFile_Ljava_lang_String_IIJJHandler")]
		public abstract global::Xposed.Services.FileResult ReadFile (string p0, int p1, int p2, long p3, long p4);

		static Delegate cb_readFile_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetReadFile_Ljava_lang_String_JJHandler ()
		{
			if (cb_readFile_Ljava_lang_String_JJ == null)
				cb_readFile_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_ReadFile_Ljava_lang_String_JJ);
			return cb_readFile_Ljava_lang_String_JJ;
		}

		static IntPtr n_ReadFile_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadFile (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("readFile", "(Ljava/lang/String;JJ)Lde/robv/android/xposed/services/FileResult;", "GetReadFile_Ljava_lang_String_JJHandler")]
		public abstract global::Xposed.Services.FileResult ReadFile (string p0, long p1, long p2);

		static Delegate cb_statFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStatFile_Ljava_lang_String_Handler ()
		{
			if (cb_statFile_Ljava_lang_String_ == null)
				cb_statFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StatFile_Ljava_lang_String_);
			return cb_statFile_Ljava_lang_String_;
		}

		static IntPtr n_StatFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xposed.Services.BaseService __this = global::Java.Lang.Object.GetObject<global::Xposed.Services.BaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StatFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='statFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("statFile", "(Ljava/lang/String;)Lde/robv/android/xposed/services/FileResult;", "GetStatFile_Ljava_lang_String_Handler")]
		public abstract global::Xposed.Services.FileResult StatFile (string p0);

	}

	[global::Android.Runtime.Register ("de/robv/android/xposed/services/BaseService", DoNotGenerateAcw=true)]
	internal partial class BaseServiceInvoker : BaseService {

		public BaseServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("de/robv/android/xposed/services/BaseService", typeof (BaseServiceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='checkFileAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("checkFileAccess", "(Ljava/lang/String;I)Z", "GetCheckFileAccess_Ljava_lang_String_IHandler")]
		public override unsafe bool CheckFileAccess (string p0, int p1)
		{
			const string __id = "checkFileAccess.(Ljava/lang/String;I)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;)[B", "GetReadFile_Ljava_lang_String_Handler")]
		public override unsafe byte[] ReadFile (string p0)
		{
			const string __id = "readFile.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("readFile", "(Ljava/lang/String;IIJJ)Lde/robv/android/xposed/services/FileResult;", "GetReadFile_Ljava_lang_String_IIJJHandler")]
		public override unsafe global::Xposed.Services.FileResult ReadFile (string p0, int p1, int p2, long p3, long p4)
		{
			const string __id = "readFile.(Ljava/lang/String;IIJJ)Lde/robv/android/xposed/services/FileResult;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Services.FileResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='readFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("readFile", "(Ljava/lang/String;JJ)Lde/robv/android/xposed/services/FileResult;", "GetReadFile_Ljava_lang_String_JJHandler")]
		public override unsafe global::Xposed.Services.FileResult ReadFile (string p0, long p1, long p2)
		{
			const string __id = "readFile.(Ljava/lang/String;JJ)Lde/robv/android/xposed/services/FileResult;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Services.FileResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='BaseService']/method[@name='statFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("statFile", "(Ljava/lang/String;)Lde/robv/android/xposed/services/FileResult;", "GetStatFile_Ljava_lang_String_Handler")]
		public override unsafe global::Xposed.Services.FileResult StatFile (string p0)
		{
			const string __id = "statFile.(Ljava/lang/String;)Lde/robv/android/xposed/services/FileResult;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Services.FileResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
