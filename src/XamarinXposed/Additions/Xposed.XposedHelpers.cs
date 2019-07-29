using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/XposedHelpers", DoNotGenerateAcw=true)]
	public sealed partial class XposedHelpers : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers.ClassNotFoundError']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/XposedHelpers$ClassNotFoundError", DoNotGenerateAcw=true)]
		public sealed partial class ClassNotFoundError : global::Java.Lang.Error {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XposedHelpers$ClassNotFoundError", typeof (ClassNotFoundError));
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

			internal ClassNotFoundError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers.InvocationTargetError']"
		[global::Android.Runtime.Register ("de/robv/android/xposed/XposedHelpers$InvocationTargetError", DoNotGenerateAcw=true)]
		public sealed partial class InvocationTargetError : global::Java.Lang.Error {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XposedHelpers$InvocationTargetError", typeof (InvocationTargetError));
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

			internal InvocationTargetError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/XposedHelpers", typeof (XposedHelpers));
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

		internal XposedHelpers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='assetAsByteArray' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='java.lang.String']]"
		[Register ("assetAsByteArray", "(Landroid/content/res/Resources;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] AssetAsByteArray (global::Android.Content.Res.Resources res, string path)
		{
			const string __id = "assetAsByteArray.(Landroid/content/res/Resources;Ljava/lang/String;)[B";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='callMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;[]'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("callMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CallMethod (global::Java.Lang.Object obj, string methodName, global::Java.Lang.Class[] parameterTypes, params global::Java.Lang.Object[] args)
		{
			const string __id = "callMethod.(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='callMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("callMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CallMethod (global::Java.Lang.Object obj, string methodName, params global::Java.Lang.Object[] args)
		{
			const string __id = "callMethod.(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='callStaticMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;[]'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("callStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CallStaticMethod (global::Java.Lang.Class clazz, string methodName, global::Java.Lang.Class[] parameterTypes, params global::Java.Lang.Object[] args)
		{
			const string __id = "callStaticMethod.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='callStaticMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("callStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CallStaticMethod (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Object[] args)
		{
			const string __id = "callStaticMethod.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='decrementMethodDepth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrementMethodDepth", "(Ljava/lang/String;)I", "")]
		public static unsafe int DecrementMethodDepth (string method)
		{
			const string __id = "decrementMethodDepth.(Ljava/lang/String;)I";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findAndHookConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("findAndHookConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;", "")]
		public static unsafe global::Xposed.XC_MethodHook.Unhook FindAndHookConstructor (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] parameterTypesAndCallback)
		{
			const string __id = "findAndHookConstructor.(Ljava/lang/Class;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;";
			IntPtr native_parameterTypesAndCallback = JNIEnv.NewArray (parameterTypesAndCallback);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypesAndCallback);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypesAndCallback != null) {
					JNIEnv.CopyArray (native_parameterTypesAndCallback, parameterTypesAndCallback);
					JNIEnv.DeleteLocalRef (native_parameterTypesAndCallback);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findAndHookConstructor' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findAndHookConstructor", "(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;", "")]
		public static unsafe global::Xposed.XC_MethodHook.Unhook FindAndHookConstructor (string className, global::Java.Lang.ClassLoader classLoader, params global::Java.Lang.Object[] parameterTypesAndCallback)
		{
			const string __id = "findAndHookConstructor.(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_parameterTypesAndCallback = JNIEnv.NewArray (parameterTypesAndCallback);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypesAndCallback);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				if (parameterTypesAndCallback != null) {
					JNIEnv.CopyArray (native_parameterTypesAndCallback, parameterTypesAndCallback);
					JNIEnv.DeleteLocalRef (native_parameterTypesAndCallback);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findAndHookMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findAndHookMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;", "")]
		public static unsafe global::Xposed.XC_MethodHook.Unhook FindAndHookMethod (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Object[] parameterTypesAndCallback)
		{
			const string __id = "findAndHookMethod.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypesAndCallback = JNIEnv.NewArray (parameterTypesAndCallback);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypesAndCallback);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypesAndCallback != null) {
					JNIEnv.CopyArray (native_parameterTypesAndCallback, parameterTypesAndCallback);
					JNIEnv.DeleteLocalRef (native_parameterTypesAndCallback);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findAndHookMethod' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("findAndHookMethod", "(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;", "")]
		public static unsafe global::Xposed.XC_MethodHook.Unhook FindAndHookMethod (string className, global::Java.Lang.ClassLoader classLoader, string methodName, params global::Java.Lang.Object[] parameterTypesAndCallback)
		{
			const string __id = "findAndHookMethod.(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Lde/robv/android/xposed/XC_MethodHook$Unhook;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypesAndCallback = JNIEnv.NewArray (parameterTypesAndCallback);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue (native_parameterTypesAndCallback);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.XC_MethodHook.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypesAndCallback != null) {
					JNIEnv.CopyArray (native_parameterTypesAndCallback, parameterTypesAndCallback);
					JNIEnv.DeleteLocalRef (native_parameterTypesAndCallback);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findClass' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register ("findClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class FindClass (string className, global::Java.Lang.ClassLoader classLoader)
		{
			const string __id = "findClass.(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;";
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findClassIfExists' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register ("findClassIfExists", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class FindClassIfExists (string className, global::Java.Lang.ClassLoader classLoader)
		{
			const string __id = "findClassIfExists.(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;";
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorBestMatch' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("findConstructorBestMatch", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorBestMatch (global::Java.Lang.Class clazz, params global::Java.Lang.Class[] parameterTypes)
		{
			const string __id = "findConstructorBestMatch.(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorBestMatch' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("findConstructorBestMatch", "(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorBestMatch (global::Java.Lang.Class clazz, global::Java.Lang.Class[] parameterTypes, global::Java.Lang.Object[] args)
		{
			const string __id = "findConstructorBestMatch.(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorBestMatch' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("findConstructorBestMatch", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorBestMatch (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] args)
		{
			const string __id = "findConstructorBestMatch.(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorExact' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("findConstructorExact", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorExact (global::Java.Lang.Class clazz, params global::Java.Lang.Class[] parameterTypes)
		{
			const string __id = "findConstructorExact.(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorExact' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("findConstructorExact", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorExact (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findConstructorExact.(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorExact' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findConstructorExact", "(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorExact (string className, global::Java.Lang.ClassLoader classLoader, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findConstructorExact.(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorExactIfExists' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("findConstructorExactIfExists", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorExactIfExists (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findConstructorExactIfExists.(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findConstructorExactIfExists' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findConstructorExactIfExists", "(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;", "")]
		public static unsafe global::Java.Lang.Reflect.Constructor FindConstructorExactIfExists (string className, global::Java.Lang.ClassLoader classLoader, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findConstructorExactIfExists.(Ljava/lang/String;Ljava/lang/ClassLoader;[Ljava/lang/Object;)Ljava/lang/reflect/Constructor;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("findField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field FindField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "findField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findFieldIfExists' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("findFieldIfExists", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field FindFieldIfExists (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "findFieldIfExists.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findFirstFieldByExactType' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("findFirstFieldByExactType", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field FindFirstFieldByExactType (global::Java.Lang.Class clazz, global::Java.Lang.Class type)
		{
			const string __id = "findFirstFieldByExactType.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/reflect/Field;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodBestMatch' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("findMethodBestMatch", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodBestMatch (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			const string __id = "findMethodBestMatch.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodBestMatch' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("findMethodBestMatch", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodBestMatch (global::Java.Lang.Class clazz, string methodName, global::Java.Lang.Class[] parameterTypes, global::Java.Lang.Object[] args)
		{
			const string __id = "findMethodBestMatch.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodBestMatch' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findMethodBestMatch", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodBestMatch (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Object[] args)
		{
			const string __id = "findMethodBestMatch.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodExact' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("findMethodExact", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodExact (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			const string __id = "findMethodExact.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodExact' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findMethodExact", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodExact (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findMethodExact.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodExact' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("findMethodExact", "(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodExact (string className, global::Java.Lang.ClassLoader classLoader, string methodName, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findMethodExact.(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodExactIfExists' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("findMethodExactIfExists", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodExactIfExists (global::Java.Lang.Class clazz, string methodName, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findMethodExactIfExists.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodExactIfExists' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("findMethodExactIfExists", "(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method FindMethodExactIfExists (string className, global::Java.Lang.ClassLoader classLoader, string methodName, params global::Java.Lang.Object[] parameterTypes)
		{
			const string __id = "findMethodExactIfExists.(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/reflect/Method;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='findMethodsByExactParameters' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("findMethodsByExactParameters", "(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)[Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method[] FindMethodsByExactParameters (global::Java.Lang.Class clazz, global::Java.Lang.Class returnType, params global::Java.Lang.Class[] parameterTypes)
		{
			const string __id = "findMethodsByExactParameters.(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)[Ljava/lang/reflect/Method;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getAdditionalInstanceField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAdditionalInstanceField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetAdditionalInstanceField (global::Java.Lang.Object obj, string key)
		{
			const string __id = "getAdditionalInstanceField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getAdditionalStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAdditionalStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetAdditionalStaticField (global::Java.Lang.Class clazz, string key)
		{
			const string __id = "getAdditionalStaticField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getAdditionalStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAdditionalStaticField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetAdditionalStaticField (global::Java.Lang.Object obj, string key)
		{
			const string __id = "getAdditionalStaticField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getBooleanField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBooleanField", "(Ljava/lang/Object;Ljava/lang/String;)Z", "")]
		public static unsafe bool GetBooleanField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getBooleanField.(Ljava/lang/Object;Ljava/lang/String;)Z";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getByteField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getByteField", "(Ljava/lang/Object;Ljava/lang/String;)B", "")]
		public static unsafe sbyte GetByteField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getByteField.(Ljava/lang/Object;Ljava/lang/String;)B";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getCharField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCharField", "(Ljava/lang/Object;Ljava/lang/String;)C", "")]
		public static unsafe char GetCharField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getCharField.(Ljava/lang/Object;Ljava/lang/String;)C";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getClassesAsArray' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getClassesAsArray", "([Ljava/lang/Class;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] GetClassesAsArray (params global::Java.Lang.Class[] clazzes)
		{
			const string __id = "getClassesAsArray.([Ljava/lang/Class;)[Ljava/lang/Class;";
			IntPtr native_clazzes = JNIEnv.NewArray (clazzes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_clazzes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Class[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
			} finally {
				if (clazzes != null) {
					JNIEnv.CopyArray (native_clazzes, clazzes);
					JNIEnv.DeleteLocalRef (native_clazzes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getDoubleField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDoubleField", "(Ljava/lang/Object;Ljava/lang/String;)D", "")]
		public static unsafe double GetDoubleField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getDoubleField.(Ljava/lang/Object;Ljava/lang/String;)D";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getFloatField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFloatField", "(Ljava/lang/Object;Ljava/lang/String;)F", "")]
		public static unsafe float GetFloatField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getFloatField.(Ljava/lang/Object;Ljava/lang/String;)F";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getIntField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIntField", "(Ljava/lang/Object;Ljava/lang/String;)I", "")]
		public static unsafe int GetIntField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getIntField.(Ljava/lang/Object;Ljava/lang/String;)I";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getLongField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLongField", "(Ljava/lang/Object;Ljava/lang/String;)J", "")]
		public static unsafe long GetLongField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getLongField.(Ljava/lang/Object;Ljava/lang/String;)J";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getMD5Sum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMD5Sum", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMD5Sum (string file)
		{
			const string __id = "getMD5Sum.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_file);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getMethodDepth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMethodDepth", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetMethodDepth (string method)
		{
			const string __id = "getMethodDepth.(Ljava/lang/String;)I";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getObjectField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getObjectField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetObjectField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getObjectField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getParameterTypes' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getParameterTypes", "([Ljava/lang/Object;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] GetParameterTypes (params global::Java.Lang.Object[] args)
		{
			const string __id = "getParameterTypes.([Ljava/lang/Object;)[Ljava/lang/Class;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Class[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getShortField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getShortField", "(Ljava/lang/Object;Ljava/lang/String;)S", "")]
		public static unsafe short GetShortField (global::Java.Lang.Object obj, string fieldName)
		{
			const string __id = "getShortField.(Ljava/lang/Object;Ljava/lang/String;)S";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticBooleanField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticBooleanField", "(Ljava/lang/Class;Ljava/lang/String;)Z", "")]
		public static unsafe bool GetStaticBooleanField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticBooleanField.(Ljava/lang/Class;Ljava/lang/String;)Z";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticByteField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticByteField", "(Ljava/lang/Class;Ljava/lang/String;)B", "")]
		public static unsafe sbyte GetStaticByteField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticByteField.(Ljava/lang/Class;Ljava/lang/String;)B";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticCharField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticCharField", "(Ljava/lang/Class;Ljava/lang/String;)C", "")]
		public static unsafe char GetStaticCharField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticCharField.(Ljava/lang/Class;Ljava/lang/String;)C";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticDoubleField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticDoubleField", "(Ljava/lang/Class;Ljava/lang/String;)D", "")]
		public static unsafe double GetStaticDoubleField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticDoubleField.(Ljava/lang/Class;Ljava/lang/String;)D";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticFloatField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticFloatField", "(Ljava/lang/Class;Ljava/lang/String;)F", "")]
		public static unsafe float GetStaticFloatField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticFloatField.(Ljava/lang/Class;Ljava/lang/String;)F";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticIntField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticIntField", "(Ljava/lang/Class;Ljava/lang/String;)I", "")]
		public static unsafe int GetStaticIntField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticIntField.(Ljava/lang/Class;Ljava/lang/String;)I";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticLongField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticLongField", "(Ljava/lang/Class;Ljava/lang/String;)J", "")]
		public static unsafe long GetStaticLongField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticLongField.(Ljava/lang/Class;Ljava/lang/String;)J";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticObjectField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticObjectField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetStaticObjectField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticObjectField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getStaticShortField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticShortField", "(Ljava/lang/Class;Ljava/lang/String;)S", "")]
		public static unsafe short GetStaticShortField (global::Java.Lang.Class clazz, string fieldName)
		{
			const string __id = "getStaticShortField.(Ljava/lang/Class;Ljava/lang/String;)S";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='getSurroundingThis' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getSurroundingThis", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetSurroundingThis (global::Java.Lang.Object obj)
		{
			const string __id = "getSurroundingThis.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='incrementMethodDepth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("incrementMethodDepth", "(Ljava/lang/String;)I", "")]
		public static unsafe int IncrementMethodDepth (string method)
		{
			const string __id = "incrementMethodDepth.(Ljava/lang/String;)I";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("newInstance", "(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object NewInstance (global::Java.Lang.Class clazz, global::Java.Lang.Class[] parameterTypes, params global::Java.Lang.Object[] args)
		{
			const string __id = "newInstance.(Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("newInstance", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object NewInstance (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] args)
		{
			const string __id = "newInstance.(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='removeAdditionalInstanceField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAdditionalInstanceField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object RemoveAdditionalInstanceField (global::Java.Lang.Object obj, string key)
		{
			const string __id = "removeAdditionalInstanceField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='removeAdditionalStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAdditionalStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object RemoveAdditionalStaticField (global::Java.Lang.Class clazz, string key)
		{
			const string __id = "removeAdditionalStaticField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='removeAdditionalStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAdditionalStaticField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object RemoveAdditionalStaticField (global::Java.Lang.Object obj, string key)
		{
			const string __id = "removeAdditionalStaticField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setAdditionalInstanceField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setAdditionalInstanceField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object SetAdditionalInstanceField (global::Java.Lang.Object obj, string key, global::Java.Lang.Object value)
		{
			const string __id = "setAdditionalInstanceField.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setAdditionalStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setAdditionalStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object SetAdditionalStaticField (global::Java.Lang.Class clazz, string key, global::Java.Lang.Object value)
		{
			const string __id = "setAdditionalStaticField.(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setAdditionalStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setAdditionalStaticField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object SetAdditionalStaticField (global::Java.Lang.Object obj, string key, global::Java.Lang.Object value)
		{
			const string __id = "setAdditionalStaticField.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setBooleanField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setBooleanField", "(Ljava/lang/Object;Ljava/lang/String;Z)V", "")]
		public static unsafe void SetBooleanField (global::Java.Lang.Object obj, string fieldName, bool value)
		{
			const string __id = "setBooleanField.(Ljava/lang/Object;Ljava/lang/String;Z)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setByteField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte']]"
		[Register ("setByteField", "(Ljava/lang/Object;Ljava/lang/String;B)V", "")]
		public static unsafe void SetByteField (global::Java.Lang.Object obj, string fieldName, sbyte value)
		{
			const string __id = "setByteField.(Ljava/lang/Object;Ljava/lang/String;B)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setCharField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char']]"
		[Register ("setCharField", "(Ljava/lang/Object;Ljava/lang/String;C)V", "")]
		public static unsafe void SetCharField (global::Java.Lang.Object obj, string fieldName, char value)
		{
			const string __id = "setCharField.(Ljava/lang/Object;Ljava/lang/String;C)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setDoubleField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("setDoubleField", "(Ljava/lang/Object;Ljava/lang/String;D)V", "")]
		public static unsafe void SetDoubleField (global::Java.Lang.Object obj, string fieldName, double value)
		{
			const string __id = "setDoubleField.(Ljava/lang/Object;Ljava/lang/String;D)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setFloatField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("setFloatField", "(Ljava/lang/Object;Ljava/lang/String;F)V", "")]
		public static unsafe void SetFloatField (global::Java.Lang.Object obj, string fieldName, float value)
		{
			const string __id = "setFloatField.(Ljava/lang/Object;Ljava/lang/String;F)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setIntField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setIntField", "(Ljava/lang/Object;Ljava/lang/String;I)V", "")]
		public static unsafe void SetIntField (global::Java.Lang.Object obj, string fieldName, int value)
		{
			const string __id = "setIntField.(Ljava/lang/Object;Ljava/lang/String;I)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setLongField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setLongField", "(Ljava/lang/Object;Ljava/lang/String;J)V", "")]
		public static unsafe void SetLongField (global::Java.Lang.Object obj, string fieldName, long value)
		{
			const string __id = "setLongField.(Ljava/lang/Object;Ljava/lang/String;J)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setObjectField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setObjectField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetObjectField (global::Java.Lang.Object obj, string fieldName, global::Java.Lang.Object value)
		{
			const string __id = "setObjectField.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setShortField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("setShortField", "(Ljava/lang/Object;Ljava/lang/String;S)V", "")]
		public static unsafe void SetShortField (global::Java.Lang.Object obj, string fieldName, short value)
		{
			const string __id = "setShortField.(Ljava/lang/Object;Ljava/lang/String;S)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticBooleanField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setStaticBooleanField", "(Ljava/lang/Class;Ljava/lang/String;Z)V", "")]
		public static unsafe void SetStaticBooleanField (global::Java.Lang.Class clazz, string fieldName, bool value)
		{
			const string __id = "setStaticBooleanField.(Ljava/lang/Class;Ljava/lang/String;Z)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticByteField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte']]"
		[Register ("setStaticByteField", "(Ljava/lang/Class;Ljava/lang/String;B)V", "")]
		public static unsafe void SetStaticByteField (global::Java.Lang.Class clazz, string fieldName, sbyte value)
		{
			const string __id = "setStaticByteField.(Ljava/lang/Class;Ljava/lang/String;B)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticCharField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char']]"
		[Register ("setStaticCharField", "(Ljava/lang/Class;Ljava/lang/String;C)V", "")]
		public static unsafe void SetStaticCharField (global::Java.Lang.Class clazz, string fieldName, char value)
		{
			const string __id = "setStaticCharField.(Ljava/lang/Class;Ljava/lang/String;C)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticDoubleField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("setStaticDoubleField", "(Ljava/lang/Class;Ljava/lang/String;D)V", "")]
		public static unsafe void SetStaticDoubleField (global::Java.Lang.Class clazz, string fieldName, double value)
		{
			const string __id = "setStaticDoubleField.(Ljava/lang/Class;Ljava/lang/String;D)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticFloatField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("setStaticFloatField", "(Ljava/lang/Class;Ljava/lang/String;F)V", "")]
		public static unsafe void SetStaticFloatField (global::Java.Lang.Class clazz, string fieldName, float value)
		{
			const string __id = "setStaticFloatField.(Ljava/lang/Class;Ljava/lang/String;F)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticIntField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setStaticIntField", "(Ljava/lang/Class;Ljava/lang/String;I)V", "")]
		public static unsafe void SetStaticIntField (global::Java.Lang.Class clazz, string fieldName, int value)
		{
			const string __id = "setStaticIntField.(Ljava/lang/Class;Ljava/lang/String;I)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticLongField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setStaticLongField", "(Ljava/lang/Class;Ljava/lang/String;J)V", "")]
		public static unsafe void SetStaticLongField (global::Java.Lang.Class clazz, string fieldName, long value)
		{
			const string __id = "setStaticLongField.(Ljava/lang/Class;Ljava/lang/String;J)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticObjectField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setStaticObjectField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetStaticObjectField (global::Java.Lang.Class clazz, string fieldName, global::Java.Lang.Object value)
		{
			const string __id = "setStaticObjectField.(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed']/class[@name='XposedHelpers']/method[@name='setStaticShortField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("setStaticShortField", "(Ljava/lang/Class;Ljava/lang/String;S)V", "")]
		public static unsafe void SetStaticShortField (global::Java.Lang.Class clazz, string fieldName, short value)
		{
			const string __id = "setStaticShortField.(Ljava/lang/Class;Ljava/lang/String;S)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

	}
}
