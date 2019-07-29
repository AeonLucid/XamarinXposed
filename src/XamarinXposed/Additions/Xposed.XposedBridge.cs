using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/XposedBridge", DoNotGenerateAcw=true)]
	public sealed partial class XposedBridge : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/field[@name='BOOTCLASSLOADER']"
		[Register ("BOOTCLASSLOADER")]
		public static global::Java.Lang.ClassLoader Bootclassloader {
			get {
				const string __id = "BOOTCLASSLOADER.Ljava/lang/ClassLoader;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/field[@name='XPOSED_BRIDGE_VERSION']"
		[Register ("XPOSED_BRIDGE_VERSION")]
		public static int XposedBridgeVersion {
			get {
				const string __id = "XPOSED_BRIDGE_VERSION.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "XPOSED_BRIDGE_VERSION.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XposedBridge", typeof (XposedBridge));
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

		internal XposedBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe int XposedVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='getXposedVersion' and count(parameter)=0]"
			[Register ("getXposedVersion", "()I", "GetGetXposedVersionHandler")]
			get {
				const string __id = "getXposedVersion.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='hookAllConstructors' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='de.robv.android.xposed.XC_MethodHook']]"
		[Register ("hookAllConstructors", "(Ljava/lang/Class;Lde/robv/android/xposed/XC_MethodHook;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Xposed.XC_MethodHook.Unhook> HookAllConstructors (global::Java.Lang.Class hookClass, global::Xposed.XC_MethodHook @callback)
		{
			const string __id = "hookAllConstructors.(Ljava/lang/Class;Lde/robv/android/xposed/XC_MethodHook;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((hookClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookClass).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<global::Xposed.XC_MethodHook.Unhook>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='hookAllMethods' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='de.robv.android.xposed.XC_MethodHook']]"
		[Register ("hookAllMethods", "(Ljava/lang/Class;Ljava/lang/String;Lde/robv/android/xposed/XC_MethodHook;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Xposed.XC_MethodHook.Unhook> HookAllMethods (global::Java.Lang.Class hookClass, string methodName, global::Xposed.XC_MethodHook @callback)
		{
			const string __id = "hookAllMethods.(Ljava/lang/Class;Ljava/lang/String;Lde/robv/android/xposed/XC_MethodHook;)Ljava/util/Set;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((hookClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookClass).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<global::Xposed.XC_MethodHook.Unhook>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='hookMethod' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Member'] and parameter[2][@type='de.robv.android.xposed.XC_MethodHook']]"
		[Register ("hookMethod", "(Ljava/lang/reflect/Member;Lde/robv/android/xposed/XC_MethodHook;)Lde/robv/android/xposed/XC_MethodHook$Unhook;", "")]
		public static unsafe global::Xposed.XC_MethodHook.Unhook HookMethod (global::Java.Lang.Reflect.IMember hookMethod, global::Xposed.XC_MethodHook @callback)
		{
			const string __id = "hookMethod.(Ljava/lang/reflect/Member;Lde/robv/android/xposed/XC_MethodHook;)Lde/robv/android/xposed/XC_MethodHook$Unhook;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((hookMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookMethod).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='invokeOriginalMethod' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Member'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("invokeOriginalMethod", "(Ljava/lang/reflect/Member;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeOriginalMethod (global::Java.Lang.Reflect.IMember method, global::Java.Lang.Object thisObject, global::Java.Lang.Object[] args)
		{
			const string __id = "invokeOriginalMethod.(Ljava/lang/reflect/Member;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				__args [1] = new JniArgumentValue ((thisObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thisObject).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void Log (string text)
		{
			const string __id = "log.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void Log (global::Java.Lang.Throwable t)
		{
			const string __id = "log.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedBridge']/method[@name='unhookMethod' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Member'] and parameter[2][@type='de.robv.android.xposed.XC_MethodHook']]"
		[Obsolete (@"deprecated")]
		[Register ("unhookMethod", "(Ljava/lang/reflect/Member;Lde/robv/android/xposed/XC_MethodHook;)V", "")]
		public static unsafe void UnhookMethod (global::Java.Lang.Reflect.IMember hookMethod, global::Xposed.XC_MethodHook @callback)
		{
			const string __id = "unhookMethod.(Ljava/lang/reflect/Member;Lde/robv/android/xposed/XC_MethodHook;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((hookMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookMethod).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
